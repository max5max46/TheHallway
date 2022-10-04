using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHallway
{
    internal class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            int Health = 15;
            int Lives = 3;
            int EnemyPresent = 1;
            int EnemyDamage = 1;
            int Enemy = 0;

            float Score = 0.0f;
            float Multiplier = 1.0f;

            Boolean loopControl = true;
            Boolean firstLoop = true;


            // Main Loop
            while (loopControl == true)
            {
                Enemy = RNG.Next(1, 5);

                if (firstLoop == false) { EnemyPresent = RNG.Next(1, 3); }

                firstLoop = false;

                if (EnemyPresent == 2)
                {
                    EnemyDamage = TakeDamage(Enemy);
                    Health = Health - EnemyDamage;

                    if (Health < 1)
                    {
                        Lives = Lives - 1;
                    }
                    else
                    {
                        Score = AddScore(Score, Multiplier, Enemy);
                        Multiplier = Multiplier + 1;
                    }
                }

                //Write Screen and HUD
                ShowHUD(Health, Lives, Score, Multiplier);
                WriteScreen(EnemyPresent, Lives, Health, Enemy);

                if (EnemyPresent == 2)
                {
                    Console.WriteLine(" The Enemy Attacked Dealing " + EnemyDamage + " Damage");

                    if (Health < 1)
                    {

                        if (Lives == 0)
                        {
                            Console.WriteLine(" You are killed, and now are but a pile of meat.");
                            loopControl = false;
                            EnemyPresent = 0;
                        }
                        else
                        {
                            Console.WriteLine(" You are killed, but your life won't fade just yet. -1 Live.");
                            Console.WriteLine(" Your Enemy Leaves.");
                            Health = 15;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" You Defeat the Enemy.\n +" + (100 * (Multiplier - 1) * Enemy) + " Score\n +1 Score Multiplier");
                        EnemyPresent = 1;
                    }
                }
                Console.WriteLine("\n Press anything to Procced");
                Console.ReadKey(true);
                Console.Clear();

            }

            //Game Over
            WriteScreen(EnemyPresent, Lives, Health, Enemy);

            Console.WriteLine("\n Score:" + Score);
            Console.WriteLine("\n Game Over");

            Console.ReadKey(true);
        }

        static void WriteScreen(int EnemyPresent, int Lives, int Health, int Enemy)
        {

            if (Lives == 0 && Health <= 0 && EnemyPresent == 0)
            {
                Console.WriteLine(" O..................................O");
                Console.WriteLine("  OOO............................OOO ");
                Console.WriteLine("     OOO......................OOO    ");
                Console.WriteLine("        Ooo................ooO       ");
                Console.WriteLine("           oooooooooooooooo          ");
                Console.WriteLine("           o    _______   o          ");
                Console.WriteLine("           o   | Here  |  o          ");
                Console.WriteLine("           o   | Lies  |  o          ");
                Console.WriteLine("           o   |       |  o          ");
                Console.WriteLine("           oooo| YOU   |ooo          ");
                Console.WriteLine("        Ooo....|_______|...ooO       ");
                Console.WriteLine("     OOO......................OOO    ");
                Console.WriteLine("  OOO............................OOO ");
                Console.WriteLine(" O..................................O\n");
            }
            else
            {
                if (EnemyPresent == 1)
                {
                    Console.WriteLine("\n O..................................O");
                    Console.WriteLine("  OOO............................OOO ");
                    Console.WriteLine("     OOO......................OOO    ");
                    Console.WriteLine("        Ooo................ooO       ");
                    Console.WriteLine("           oooooooooooooooo          ");
                    Console.WriteLine("           o              o          ");
                    Console.WriteLine("           o              o          ");
                    Console.WriteLine("           o              o          ");
                    Console.WriteLine("           o              o          ");
                    Console.WriteLine("           oooooooooooooooo          ");
                    Console.WriteLine("        Ooo................ooO       ");
                    Console.WriteLine("     OOO......................OOO    ");
                    Console.WriteLine("  OOO............................OOO ");
                    Console.WriteLine(" O..................................O");
                    Console.WriteLine("\n No Enemy Here...");

                }
                else
                {

                    switch (Enemy)
                    {
                        case 1:
                            Console.WriteLine("\n O..................................O");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("           o              o          ");
                            Console.WriteLine("           o      AA      o          ");
                            Console.WriteLine("           o      AA      o          ");
                            Console.WriteLine("           o              o          ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine(" O..................................O");
                            Console.WriteLine("\n A Wild (A) Block Appeared!");
                            break;

                        case 2:
                            Console.WriteLine("\n O..................................O");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("           o              o          ");
                            Console.WriteLine("           o      BB      o          ");
                            Console.WriteLine("           o      BB      o          ");
                            Console.WriteLine("           o              o          ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine(" O..................................O");
                            Console.WriteLine("\n A Wild (B) Block Appeared!");
                            break;

                        case 3:
                            Console.WriteLine("\n O..................................O");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("           o              o          ");
                            Console.WriteLine("           o      CC      o          ");
                            Console.WriteLine("           o      CC      o          ");
                            Console.WriteLine("           o              o          ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine(" O..................................O");
                            Console.WriteLine("\n A Wild (C) Block Appeared!");
                            break;

                        case 4:
                            Console.WriteLine("\n O..................................O");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("           o      SUS     o          ");
                            Console.WriteLine("           o     SU+++    o          ");
                            Console.WriteLine("           o     USUS     o          ");
                            Console.WriteLine("           o      U U     o          ");
                            Console.WriteLine("           oooooooooooooooo          ");
                            Console.WriteLine("        Ooo................ooO       ");
                            Console.WriteLine("     OOO......................OOO    ");
                            Console.WriteLine("  OOO............................OOO ");
                            Console.WriteLine(" O..................................O");
                            Console.WriteLine("\n Oh No....");
                            break;
                    }
                }
            }

        }
        static void ShowHUD(int Health, int Lives, float Score, float Multiplier)
        {
            Console.WriteLine(" *** The HallWay By Dylan Adams ***\n");
            Console.WriteLine(" STATS ---- Health: " + Health + "  Lives: " + Lives + "  Score: " + Score + "  Score Multiplier: " + Multiplier);
        }

        static float AddScore(float Score, float Multiplier, int Enemy)
        {
            return (Score + (100 * Multiplier * Enemy));
        }

        static int TakeDamage(int Enemy)
        {
            return (Enemy + RNG.Next(0, 3));
        }
    }
}
