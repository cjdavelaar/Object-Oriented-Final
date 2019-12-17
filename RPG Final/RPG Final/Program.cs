using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(100, 25, "sword");

            var rand = new Random();
            int dmg, seed;

            Console.WriteLine("Enter the seed for your game: ");
            seed = Console.Read();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.ReadLine();

            for( int i = 0; i < seed; i++ )
                dmg = rand.Next();

            Console.WriteLine("Every year it is tradition for one young man from your village to be selected to " +
                "enter the dungeon and return with the\ncoveted treasure. There have been no sucessful attempts " +
                "that you remember. This year, you have been selected.");

            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();

            Console.WriteLine("You are handed a sword, a torch, a map, and enough food for one week. You take one final " +
                "look back before walking\nthrough the entrance. Your family is crying and the rest of your village " +
                "is cheering you good luck. In that moment\nyou know you are going to find that treasure.");

            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();

            Console.WriteLine("You start walking in the dungeon following the directions on the map. The passageways are" +
                " dimly lit by the light coming\noff of your torch. Suddenly you hear a loud noise. You look ahead and can " +
                "see the outline of a doorway. You sprint\nahead with your sword ready for batte.");

            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();

            Console.WriteLine("As you enter the large room, an object flies by your head. You quickly seek cover behind " +
            "a pillar. Seeing a figure in\nfront of you, you charge into battle.");

            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();

            char input;

            dmg = rand.Next(1, 6);
            var enemy = new RPG.Skeleton(55, 10, "bow");
            var enemy1 = new RPG.Giant(55, 10, "club");
            var enemy2 = new RPG.Ogre(55, 10, "cleaver");
            var enemy3 = new RPG.Orc(55, 10, "battleaxe");
            var enemy4 = new RPG.Troll(55, 10, "greatsword");
            var enemy5 = new RPG.Dragon(55, 10, "fire");

            if (dmg == 1)
            {
                Console.WriteLine("You encounter an {0}.\n", enemy.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy.name, dmg);

                        dmg = rand.Next(0, enemy.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if(dmg == 2)
            {
                Console.WriteLine("You encounter an {0}.\n", enemy2.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy2.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy2.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy2.name, dmg);

                        dmg = rand.Next(0, enemy2.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy2.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy2.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy2.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy2.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 3)
            {
                Console.WriteLine("You encounter an {0}.\n", enemy3.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy3.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy3.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy3.name, dmg);

                        dmg = rand.Next(0, enemy3.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy3.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }
                if (enemy3.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy3.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy3.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 4)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy4.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy4.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy4.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy4.name, dmg);

                        dmg = rand.Next(0, enemy4.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy4.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy4.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy4.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy4.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 5)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy5.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy5.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy5.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy5.name, dmg);

                        dmg = rand.Next(0, enemy5.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy5.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy5.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy5.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy5.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy5.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy5.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 6)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy1.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy1.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy1.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy1.name, dmg);

                        dmg = rand.Next(0, enemy1.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy1.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy1.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy1.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy1.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }

            Console.WriteLine("You catch your breath and leave the site of the battle. Moving forward, you find a location" +
                " filled with armor and items\nfrom past adventurers\n");

            SearchPrintMenu();
            input = Console.ReadLine()[0];

            if( input == '1' )
            {
                dmg = rand.Next(1, 10);
                player.Heal(dmg);
                Console.WriteLine("\n\nYou heal for {0} hp. You new health is {1}.\n", dmg, player.health);
            }
            else if( input == '2')
            {
                dmg = rand.Next(1, 5);
                if(dmg == 1)
                {
                    Console.WriteLine("You fall in a hole while searching through rubble. You find your way back" +
                        " to the path on the map\nin one day's time. You must conserve your food supplies now " +
                        "and lose 5 health points.\n");
                    player.TakeDamage(5);
                }
                else if(dmg == 2)
                {
                    Console.WriteLine("You find a grindstone from a former adventurer. You use it on your sword " +
                        "and gain 3 points to your attack damage.\n");
                    player.dmg += 3;

                }
                else if (dmg == 3)
                {
                    Console.WriteLine("You find dried fruit from a previous traveler. You can now increase your " +
                        "daily ration of food. You gain 5 health points.\n");
                    player.Heal(5);
                }
                else if (dmg == 4)
                {
                    Console.WriteLine("You find nuts from a previous traveler. You can now increase your " +
                    "daily ration of food. You gain 5 health points.\n");
                    player.Heal(5);
                }
                else
                {
                    Console.WriteLine("You find a longsword from a previous adventurer. It is stronger than " +
                        "your current sword and swap\nthem out. You gain 5 points to your attack damage.\n");
                    player.dmg += 5;
                }
            }
            else
            {
                goto end;
            }

            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();

            Console.WriteLine("Leaving the site of the past travelers, you enter a long hallway. You think" +
                " you see a figure at the\nend of it but you are not sure. You get closer slowly and it starts" +
                " charging at you.");

            enemy = new RPG.Skeleton(55, 10, "bow");
            enemy1 = new RPG.Giant(55, 10, "club");
            enemy2 = new RPG.Ogre(55, 10, "cleaver");
            enemy3 = new RPG.Orc(55, 10, "battleaxe");
            enemy4 = new RPG.Troll(55, 10, "greatsword");
            enemy5 = new RPG.Dragon(55, 10, "fire");

            if (dmg == 1)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy.name, dmg);

                        dmg = rand.Next(0, enemy.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 2)
            {
                Console.WriteLine("You encounter an {0}.\n", enemy2.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy2.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy2.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy2.name, dmg);

                        dmg = rand.Next(0, enemy2.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy2.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy2.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy2.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy2.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 3)
            {
                Console.WriteLine("You encounter an {0}.\n", enemy3.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy3.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy3.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy3.name, dmg);

                        dmg = rand.Next(0, enemy3.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy3.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }
                if (enemy3.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy3.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy3.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 4)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy4.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy4.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy4.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy4.name, dmg);

                        dmg = rand.Next(0, enemy4.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy4.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy4.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy4.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy4.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 5)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy5.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy5.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy5.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy5.name, dmg);

                        dmg = rand.Next(0, enemy5.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy5.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy5.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy5.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy5.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy5.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy5.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }
            else if (dmg == 6)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy1.name);
                PrintMenu();
                input = Console.ReadLine()[0];

                while (enemy1.health > 0 && player.health > 0 && input != 'q')
                {
                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy1.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy1.name, dmg);

                        dmg = rand.Next(0, enemy1.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                    }
                    else
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy1.name);
                        else
                            Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                    }

                    PrintMenu();
                    input = Console.ReadLine()[0];
                }

                if (enemy1.health <= 0)
                    Console.WriteLine("You have defeated the {0}.\n", enemy1.name);
                else if (player.health <= 0)
                {
                    Console.WriteLine("You have been defeated by the {0}.\n", enemy1.name);
                    goto end;
                }
                else
                    goto end;

                Console.WriteLine("\n\nPress enter to continue...\n");
                Console.ReadLine();
            }

            Console.WriteLine("You leave the site of the battle and rest for a bit. Once refreshed, you start moving forward " +
                "and find another location filled\nwith armor and items\nfrom past adventurers\n");

            SearchPrintMenu();
            input = Console.ReadLine()[0];

            if (input == '1')
            {
                dmg = rand.Next(1, 10);
                player.Heal(dmg);
                Console.WriteLine("\n\nYou heal for {0} hp. You new health is {1}.\n", dmg, player.health);
            }
            else if (input == '2')
            {
                dmg = rand.Next(1, 5);
                if (dmg == 1)
                {
                    Console.WriteLine("You fall in a hole while searching through rubble. You find your way back" +
                        " to the path on the map\nin one day's time. You must conserve your food supplies now " +
                        "and lose 5 health points.\n");
                    player.TakeDamage(5);
                }
                else if (dmg == 2)
                {
                    Console.WriteLine("You find a grindstone from a former adventurer. You use it on your sword " +
                        "and gain 3 points to your attack damage.\n");
                    player.dmg += 3;

                }
                else if (dmg == 3)
                {
                    Console.WriteLine("You find dried fruit from a previous traveler. You can now increase your " +
                        "daily ration of food. You gain 5 health points.\n");
                    player.Heal(5);
                }
                else if (dmg == 4)
                {
                    Console.WriteLine("You find nuts from a previous traveler. You can now increase your " +
                    "daily ration of food. You gain 5 health points.\n");
                    player.Heal(5);
                }
                else
                {
                    Console.WriteLine("You find a longsword from a previous adventurer. It is stronger than " +
                        "your current sword and swap\nthem out. You gain 5 points to your attack damage.\n");
                    player.dmg += 5;
                }
            }
            else
            {
                goto end;
            }

        end:;
        }

        static void PrintMenu()
        {
            Console.WriteLine("Choose an Option:\n1. Attack\n2. Dodge\nq. quit(the entire game)\n");
        }

        static void SearchPrintMenu()
        {
            Console.WriteLine("Choose an Option:\n1. Heal\n2. Explore\nq. quit(the entire game)\n");
        }
    }
}
