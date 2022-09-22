using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHallway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Health = 10;
            int Lives = 3;
            int EnemyPresent = 1;
            int Enemy = 1;
            int EnemyDamage = 1;

            float Score = 0.0f;
            float Multiplier = 1.0f;

            Boolean loopControl = true;
            Boolean firstLoop = true;

            Random RNG = new Random();

            while (loopControl == true)
            {
                if (firstLoop == false) { EnemyPresent = RNG.Next(1, 3); }

                firstLoop = false;

                if (EnemyPresent == 2)
                {
                    EnemyDamage = RNG.Next(1, 4);
                    Health = Health - EnemyDamage;

                    if (Health < 1)
                    {
                        Lives = Lives - 1;
                    }
                    else
                    {
                        Score = Score + (100 * Multiplier);
                        Multiplier = Multiplier + 1;
                    }
                }

                Console.WriteLine(" *** The HallWay By Dylan Adams ***\n");
                Console.WriteLine(" STATS ---- Health: " + Health + "  Lives: " + Lives + "  Score: " + Score + "  Score Multiplier: " + Multiplier);

                
                Enemy = RNG.Next(1,5);


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

                if (EnemyPresent == 2)
                {
                    Console.WriteLine(" The Enemy Attacked Dealing " + EnemyDamage + " Damage");

                    if (Health < 1)
                    {

                        if (Lives == 0)
                        {
                            Console.WriteLine(" You are killed, and now are but a pile of meat.");
                            loopControl = false;
                        }
                        else
                        {
                            Console.WriteLine(" You are killed, but your life won't fade just yet. -1 Live.");
                            Console.WriteLine(" Your Enemy Leaves.");
                            Health = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" You Defeat the Enemy.\n +" + (100 * (Multiplier - 1)) + " Score\n +1 Score Multiplier");
                        EnemyPresent = 1;
                    }
                }

                Console.WriteLine("\n Press anything to Procced");
                Console.ReadKey(true);
                Console.Clear();

            }

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
            Console.WriteLine(" O..................................O");

            Console.WriteLine("\n Score:" + Score);
            Console.WriteLine("\n Game Over");

            Console.ReadKey(true);
        }
    }
}
