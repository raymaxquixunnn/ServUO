#region References
using System;

using Server.Items;
using Server.Misc;
using Server.Network;
using Server.Targeting;
#endregion

namespace Server.SkillHandlers
{
    public class Begging
    {
        public static void Initialize()
        {
            SkillInfo.Table[(int)SkillName.Begging].Callback = OnUse;
        }

        public static TimeSpan OnUse(Mobile m)
        {
            m.RevealingAction();

            m.SendLocalizedMessage(500397); // To whom do you wish to grovel?

            Timer.DelayCall(() => m.Target = new InternalTarget());

            return TimeSpan.FromHours(1.0);
        }

        private class InternalTarget : Target
        {
            private bool m_SetSkillTime = true;

            public InternalTarget()
                : base(12, false, TargetFlags.None)
            { }

            protected override void OnTargetFinish(Mobile from)
            {
                if (m_SetSkillTime)
                {
                    from.NextSkillTime = Core.TickCount;
                }
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                from.RevealingAction();

                int number = -1;

                if (targeted is Mobile)
                {
                    Mobile targ = (Mobile)targeted;

                    if (targ.Player) // We can't beg from players
                    {
                        number = 500398; // Perhaps just asking would work better.
                    }
                    else if (!targ.Body.IsHuman) // Make sure the NPC is human
                    {
                        number = 500399; // There is little chance of getting money from that!
                    }
                    else if (!from.InRange(targ, 2))
                    {
                        if (!targ.Female)
                        {
                            number = 500401; // You are too far away to beg from him.
                        }
                        else
                        {
                            number = 500402; // You are too far away to beg from her.
                        }
                    }
                    else if (!Core.ML && from.Mounted) // If we're on a mount, who would give us money? TODO: guessed it's removed since ML
                    {
                        number = 500404; // They seem unwilling to give you any money.
                    }
                    else
                    {
                        // Face eachother
                        from.Direction = from.GetDirectionTo(targ);
                        targ.Direction = targ.GetDirectionTo(from);

                        from.Animate(32, 5, 1, true, false, 0); // Bow

                        new InternalTimer(from, targ).Start();

                        m_SetSkillTime = false;
                    }
                }
                else // Not a Mobile
                {
                    number = 500399; // There is little chance of getting money from that!
                }

                if (number != -1)
                {
                    from.SendLocalizedMessage(number);
                }
            }

            private class InternalTimer : Timer
            {
                private readonly Mobile m_From;
                private readonly Mobile m_Target;

                public InternalTimer(Mobile from, Mobile target)
                    : base(TimeSpan.FromSeconds(2.0))
                {
                    m_From = from;
                    m_Target = target;
                    Priority = TimerPriority.TwoFiftyMS;
                }

                protected override void OnTick()
                {
                    Container theirPack = m_Target.Backpack;

                    double badKarmaChance = 0.5 - ((double)m_From.Karma / 8570);

                    if (theirPack == null && m_Target.Race != Race.Elf)
                    {
                        m_From.SendLocalizedMessage(500404); // They seem unwilling to give you any money.
                    }
                    else if (m_From.Karma < 0 && badKarmaChance > Utility.RandomDouble())
                    {
                        m_Target.PublicOverheadMessage(MessageType.Regular, m_Target.SpeechHue, 500406);
                        // Thou dost not look trustworthy... no gold for thee today!
                    }
                    else if (m_From.CheckTargetSkill(SkillName.Begging, m_Target, 0.0, 100.0))
                    {
                        if (m_Target.Race != Race.Elf)
                        {
                            int toConsume = theirPack.GetAmount(typeof(Gold)) / 10;
                            int max = 10 + (m_From.Fame / 2500);

                            if (max > 14)
                            {
                                max = 14;
                            }
                            else if (max < 10)
                            {
                                max = 10;
                            }

                            if (toConsume > max)
                            {
                                toConsume = max;
                            }

                            if (toConsume > 0)
                            {
                                int consumed = theirPack.ConsumeUpTo(typeof(Gold), toConsume);

                                if (consumed > 0)
                                {
                                    m_Target.PublicOverheadMessage(MessageType.Regular, m_Target.SpeechHue, 500405);
                                    // I feel sorry for thee...

                                    Gold gold = new Gold(consumed);

                                    m_From.AddToBackpack(gold);
                                    m_From.PlaySound(gold.GetDropSound());

                                    if (m_From.Karma > -3000)
                                    {
                                        int toLose = m_From.Karma + 3000;

                                        if (toLose > 40)
                                        {
                                            toLose = 40;
                                        }

                                        Titles.AwardKarma(m_From, -toLose, true);
                                    }
                                }
                                else
                                {
                                    m_Target.PublicOverheadMessage(MessageType.Regular, m_Target.SpeechHue, 500407);
                                    // I have not enough money to give thee any!
                                }
                            }
                            else
                            {
                                m_Target.PublicOverheadMessage(MessageType.Regular, m_Target.SpeechHue, 500407);
                                // I have not enough money to give thee any!
                            }
                        }
                        else
                        {
                            double chance = Utility.RandomDouble();
                            Item reward = null;
                            string rewardName = "";
                            if (chance >= 0.999999999999999)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Kilt();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Shirt();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Scepter();
                                }
                                else if (rand == 3)
                                {
                                    reward = new RingmailChest();
                                }
                                else if (rand == 4)
                                {
                                    reward = new Cutlass();
                                }
                            }

                            else if (chance >= 0.999999999999998)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Obi();
                                }
                                else if (rand == 1)
                                {
                                    reward = new SamuraiTabi();
                                }
                                else if (rand == 2)
                                {
                                    reward = new FancyKilt();
                                }
                                else if (rand == 3)
                                {
                                    reward = new GargoyleHalfApron();
                                }
                                else if (rand == 4)
                                {
                                    reward = new HalfApron();
                                }
                            }

                            else if (chance >= 0.999999999999995)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Cleaver();
                                }
                                else if (rand == 1)
                                {
                                    reward = new GargishCleaver();
                                }
                                else if (rand == 2)
                                {
                                    reward = new JesterShoes();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Key();
                                }
                                else if (rand == 4)
                                {
                                    reward = new MortarPestle();
                                }
                            }

                            else if (chance >= 0.999999999999985)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Shoes();
                                }
                                else if (rand == 1)
                                {
                                    reward = new RingmailArms();
                                }
                                else if (rand == 2)
                                {
                                    reward = new GargishMaul();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Maul();
                                }
                                else if (rand == 4)
                                {
                                    reward = new RingmailLegs();
                                }
                            }


                            else if (chance >= 0.999999999999956)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new HeavyGrapeshot();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Matches();
                                }
                                else if (rand == 2)
                                {
                                    reward = new N10HealPotion();
                                }
                                else if (rand == 3)
                                {
                                    reward = new PoisonPotion();
                                }
                                else if (rand == 4)
                                {
                                    reward = new SweetCocoaButter();
                                }
                            }

                            else if (chance >= 0.999999999999869)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Mace();
                                }
                                else if (rand == 1)
                                {
                                    reward = new AgilityPotion();
                                }
                                else if (rand == 2)
                                {
                                    reward = new ChocolateNutcracker();
                                }
                                else if (rand == 3)
                                {
                                    reward = new DarkChocolate();
                                }
                                else if (rand == 4)
                                {
                                    reward = new HealPotion();
                                }
                            }

                            else if (chance >= 0.999999999999607)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new TinkerTools();
                                }
                                else if (rand == 1)
                                {
                                    reward = new RingmailGloves();
                                }
                                else if (rand == 2)
                                {
                                    reward = new PlainDress();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Sandals();
                                }
                                else if (rand == 4)
                                {
                                    reward = new ChainCoif();
                                }
                            }

                            else if (chance >= 0.99999999999882)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Goblet();
                                }
                                else if (rand == 1)
                                {
                                    reward = new HeavyCannonball();
                                }
                                else if (rand == 2)
                                {
                                    reward = new KeyRing();
                                }
                                else if (rand == 3)
                                {
                                    reward = new PewterMug();
                                }
                                else if (rand == 4)
                                {
                                    reward = new SewingKit();
                                }
                            }

                            else if (chance >= 0.999999999996459)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new JesterSuit();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Surcoat();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Bascinet();
                                }
                                else if (rand == 3)
                                {
                                    reward = new DungeonNightSightPotion();
                                }
                                else if (rand == 4)
                                {
                                    reward = new FlowerGarland();
                                }
                            }

                            else if (chance >= 0.999999999989378)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new TricorneHat();
                                }
                                else if (rand == 1)
                                {
                                    reward = new WideBrimHat();
                                }
                                else if (rand == 2)
                                {
                                    reward = new TallStrawHat();
                                }
                                else if (rand == 3)
                                {
                                    reward = new JesterHat();
                                }
                                else if (rand == 4)
                                {
                                    reward = new WizardsHat();
                                }
                            }

                            else if (chance >= 0.999999999968134)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new ChefsToque();
                                }
                                else if (rand == 1)
                                {
                                    reward = new FeatheredHat();
                                }
                                else if (rand == 2)
                                {
                                    reward = new FloppyHat();
                                }
                                else if (rand == 3)
                                {
                                    reward = new LeatherCap();
                                }
                                else if (rand == 4)
                                {
                                    reward = new StrawHat();
                                }
                            }

                            else if (chance >= 0.999999999904401)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new LesserExplosionPotion();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Scissors();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Springs();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Bonnet();
                                }
                                else if (rand == 4)
                                {
                                    reward = new Cap();
                                }
                            }

                            else if (chance >= 0.999999999713203)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new GargishSash();
                                }
                                else if (rand == 1)
                                {
                                    reward = new GargishKiteShield();
                                }
                                else if (rand == 2)
                                {
                                    reward = new MetalKiteShield();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Gears();
                                }
                                else if (rand == 4)
                                {
                                    reward = new Hinge();
                                }
                            }

                            else if (chance >= 0.999999999139608)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new UncookedSausagePizza();
                                }
                                else if (rand == 1)
                                {
                                    reward = new WallSafeDeed();
                                }
                                else if (rand == 2)
                                {
                                    reward = new WarriorStatueEastDeed();
                                }
                                else if (rand == 3)
                                {
                                    reward = new WarriorStatueSouthDeed();
                                }
                                else if (rand == 4)
                                {
                                    reward = new BodySash();
                                }
                            }

                            else if (chance >= 0.999999992256476)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Swab();
                                }
                                else if (rand == 1)
                                {
                                    reward = new SweetDough();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Tunic();
                                }
                                else if (rand == 3)
                                {
                                    reward = new UnbakedApplePie();
                                }
                                else if (rand == 4)
                                {
                                    reward = new UnbakedFruitPie();
                                }
                            }

                            else if (chance >= 0.999999976769427)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new SmoothingPlane();
                                }
                                else if (rand == 1)
                                {
                                    reward = new SpoonLeft();
                                }
                                else if (rand == 2)
                                {
                                    reward = new SpoonRight();
                                }
                                else if (rand == 3)
                                {
                                    reward = new SquirrelStatueEastDeed();
                                }
                                else if (rand == 4)
                                {
                                    reward = new SquirrelStatueSouthDeed();
                                }
                            }

                            else if (chance >= 0.999999930308281)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new SausagePizza();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Sextant();
                                }
                                else if (rand == 2)
                                {
                                    reward = new SextantParts();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Shaft();
                                }
                                else if (rand == 4)
                                {
                                    reward = new SkullCap();
                                }
                            }

                            else if (chance >= 0.999999790924842)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new PumpkinPie();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Quiche();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Ribs();
                                }
                                else if (rand == 3)
                                {
                                    reward = new RollingPin();
                                }
                                else if (rand == 4)
                                {
                                    reward = new SackFlour();
                                }
                            }

                            else if (chance >= 0.999999372774526)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new MouldingPlane();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Muffins();
                                }
                                else if (rand == 2)
                                {
                                    reward = new PeachCobbler();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Plate();
                                }
                                else if (rand == 4)
                                {
                                    reward = new Potash();
                                }
                            }

                            else if (chance >= 0.999998118323577)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new LambLeg();
                                }
                                else if (rand == 1)
                                {
                                    reward = new LightCannonball();
                                }
                                else if (rand == 2)
                                {
                                    reward = new LightGrapeshot();
                                }
                                else if (rand == 3)
                                {
                                    reward = new LightPowderCharge();
                                }
                                else if (rand == 4)
                                {
                                    reward = new MeatPie();
                                }
                            }

                            else if (chance >= 0.999994354970731)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new HeavyPowderCharge();
                                }
                                else if (rand == 1)
                                {
                                    reward = new HotCocoaMug();
                                }
                                else if (rand == 2)
                                {
                                    reward = new JointingPlane();
                                }
                                else if (rand == 3)
                                {
                                    reward = new KnifeLeft();
                                }
                                else if (rand == 4)
                                {
                                    reward = new KnifeRight();
                                }
                            }

                            else if (chance >= 0.999983064912192)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new ForkLeft();
                                }
                                else if (rand == 1)
                                {
                                    reward = new ForkRight();
                                }
                                else if (rand == 2)
                                {
                                    reward = new FriedEggs();
                                }
                                else if (rand == 3)
                                {
                                    reward = new FruitPie();
                                }
                                else if (rand == 4)
                                {
                                    reward = new GargishDagger();
                                }
                            }

                            else if (chance >= 0.999949194736575)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Cookies();
                                }
                                else if (rand == 1)
                                {
                                    reward = new CutUpCloth();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Doublet();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Dough();
                                }
                                else if (rand == 4)
                                {
                                    reward = new FishSteak();
                                }
                            }

                            else if (chance >= 0.999847584209724)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new CocoaLiquor();
                                }
                                else if (rand == 1)
                                {
                                    reward = new CoffeeMug();
                                }
                                else if (rand == 2)
                                {
                                    reward = new CombineCloth();
                                }
                                else if (rand == 3)
                                {
                                    reward = new CookedBird();
                                }
                                else if (rand == 4)
                                {
                                    reward = new CookieMix();
                                }
                            }

                            else if (chance >= 0.999542752629172)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new ClockFrame();
                                }
                                else if (rand == 1)
                                {
                                    reward = new ClockLeft();
                                }
                                else if (rand == 2)
                                {
                                    reward = new ClockParts();
                                }
                                else if (rand == 3)
                                {
                                    reward = new ClockRight();
                                }
                                else if (rand == 4)
                                {
                                    reward = new CocoaButter();
                                }
                            }

                            else if (chance >= 0.998628257887517)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Cake();
                                }
                                else if (rand == 1)
                                {
                                    reward = new CakeMix();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Charcoal();
                                }
                                else if (rand == 3)
                                {
                                    reward = new CheesePizza();
                                }
                                else if (rand == 4)
                                {
                                    reward = new ChickenLeg();
                                }
                            }

                            else if (chance >= 0.995884773662551)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Bandana();
                                }
                                else if (rand == 1)
                                {
                                    reward = new BasketOfGreenTeaMug();
                                }
                                else if (rand == 2)
                                {
                                    reward = new Bolt();
                                }
                                else if (rand == 3)
                                {
                                    reward = new BowlOfRotwormStew();
                                }
                                else if (rand == 4)
                                {
                                    reward = new BreadLoaf();
                                }
                            }

                            else if (chance >= 0.990000000000000)
                            {
                                int rand = Utility.Random(8);

                                if (rand == 0)
                                {
                                    reward = new BegBedRoll();
                                    rewardName = "a bedroll";
                                }
                                else if (rand == 1)
                                {
                                    reward = new BegCookies();
                                    rewardName = "a plate of cookies.";
                                }
                                else if (rand == 2)
                                {
                                    reward = new BegFishSteak();
                                    rewardName = "a fish steak.";
                                }
                                else if (rand == 3)
                                {
                                    reward = new BegFishingPole();
                                    rewardName = "a fishing pole.";
                                }
                                else if (rand == 4)
                                {
                                    reward = new BegFlowerGarland();
                                    rewardName = "a flower garland.";
                                }
                                else if (rand == 5)
                                {
                                    reward = new BegSake();
                                    rewardName = "a bottle of Sake.";
                                }
                                else if (rand == 6)
                                {
                                    reward = new BegTurnip();
                                    rewardName = "a turnip.";
                                }
                                else if (rand == 7)
                                {
                                    reward = new BegWine();
                                    rewardName = "a Bottle of wine.";
                                }
                                else if (rand == 8)
                                {
                                    reward = new BegWinePitcher();
                                    rewardName = "a Pitcher of wine.";
                                }
                            }

                            else if (chance >= 0.987654320987654)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new ApplePie();
                                }
                                else if (rand == 1)
                                {
                                    reward = new ArcanistStatueEastDeed();
                                }
                                else if (rand == 2)
                                {
                                    reward = new ArcanistStatueSouthDeed();
                                }
                                else if (rand == 3)
                                {
                                    reward = new Arrow();
                                }
                                else if (rand == 4)
                                {
                                    reward = new AxleGears();
                                }
                            }

                            else if (chance >= 0.962962962962963)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new MediumPlateShield();
                                }
                                else if (rand == 1)
                                {
                                    reward = new MetalShield();
                                }
                                else if (rand == 2)
                                {
                                    reward = new LesserCurePotion();
                                }
                                else if (rand == 3)
                                {
                                    reward = new LesserPoisonPotion();
                                }
                                else if (rand == 4)
                                {
                                    reward = new Dagger();
                                }
                            }

                            else if (chance >= 0.888888888888889)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new RefreshPotion();
                                }
                                else if (rand == 1)
                                {
                                    reward = new SmallPlateShield();
                                }
                                else if (rand == 2)
                                {
                                    reward = new BronzeShield();
                                }
                                else if (rand == 3)
                                {
                                    reward = new WoodenKiteShield();
                                }
                                else if (rand == 4)
                                {
                                    reward = new BarrelHoops();
                                }
                            }
 
                            else if (chance >= 0.760000000000000)
                            {
                                int rand = Utility.Random(6);

                                if (rand == 0)
                                {
                                    reward = new BegStew();
                                    rewardName = "a bowl of stew.";
                                }
                                else if (rand == 1)
                                {
                                    reward = new BegCheeseWedge();
                                    rewardName = "a wedge of cheese.";
                                }
                                else if (rand == 2)
                                {
                                    reward = new BegDates();
                                    rewardName = "a bunch of dates.";
                                }
                                else if (rand == 3)
                                {
                                    reward = new BegLantern();
                                    rewardName = "a lantern.";
                                }
                                else if (rand == 4)
                                {
                                    reward = new BegLiquorPitcher();
                                    rewardName = "a Pitcher of liquor";
                                }
                                else if (rand == 5)
                                {
                                    reward = new BegPizza();
                                    rewardName = "pizza";
                                }
                                else if (rand == 6)
                                {
                                    reward = new BegShirt();
                                    rewardName = "a shirt.";
                                }
                            }

                            else if (chance >= 0.666666666666667)
                            {
                                int rand = Utility.Random(4);

                                if (rand == 0)
                                {
                                    reward = new Axle();
                                }
                                else if (rand == 1)
                                {
                                    reward = new Buckler();
                                }
                                else if (rand == 2)
                                {
                                    reward = new L10HealPotion();
                                }
                                else if (rand == 3)
                                {
                                    reward = new LesserHealPotion();
                                }
                                else if (rand == 4)
                                {
                                    reward = new NightSightPotion();
                                }
                            }

                            else if (chance >= 0.250000000000000)
                            {
                                int rand = Utility.Random(1);

                                if (rand == 0)
                                {
                                    reward = new BegFrenchBread();
                                    rewardName = "french bread.";
                                }
                                else
                                {
                                    reward = new BegWaterPitcher();
                                    rewardName = "a Pitcher of water.";
                                }
                            }

                            if (reward == null)
                            {
                                reward = new Gold(1);
                            }

                            m_Target.Say(1074854); // Here, take this...
                            m_From.AddToBackpack(reward);
                            m_From.SendLocalizedMessage(1074853, rewardName); // You have been given ~1_name~

                            if (m_From.Karma > -3000)
                            {
                                int toLose = m_From.Karma + 3000;

                                if (toLose > 40)
                                {
                                    toLose = 40;
                                }

                                Titles.AwardKarma(m_From, -toLose, true);
                            }

                        }
                    }

                    else
                    {
                        m_Target.SendLocalizedMessage(500404); // They seem unwilling to give you any money.
                    }

                    m_From.NextSkillTime = Core.TickCount + 10000;
                }
            }
        }
    }
}