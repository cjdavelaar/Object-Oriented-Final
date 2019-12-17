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

            dmg = rand.Next(1, 5);
            var enemy = new RPG.Skeleton(55, 10, "bow");
            var enemy1 = new RPG.Giant(55, 10, "club");
            var enemy2 = new RPG.Ogre(55, 10, "cleaver");
            var enemy3 = new RPG.Orc(55, 10, "battleaxe");
            var enemy4 = new RPG.Troll(55, 10, "greatsword");

            if (dmg == 1)
            {
                Console.WriteLine("You encounter an {0}.\n", enemy.name);
                input = 'a';
                while (enemy.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy.name, dmg);

                        if (enemy.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                        }
                    }
                    else
                        goto end;
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
                input = 'a';
                while (enemy2.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy2.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy2.name, dmg);

                        if (enemy2.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy2.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy2.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                        }
                    }
                    else
                        goto end;
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

                input = 'a';

                while (enemy3.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy3.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy3.name, dmg);

                        if (enemy3.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy3.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy3.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                        }
                    }
                    else
                        goto end;
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

                input = 'a';

                while (enemy4.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy4.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy4.name, dmg);

                        if (enemy4.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy4.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy4.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                        }
                    }
                    else
                        goto end;
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
                Console.WriteLine("You encounter a {0}.\n", enemy1.name);

                input = 'a';

                while (enemy1.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy1.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy1.name, dmg);

                        if (enemy1.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy1.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy1.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                        }
                    }
                    else
                        goto end;
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

            input = 'a';

            SearchPrintMenu();
            while (input != '1' && input != '2' && input != 'q')
            {
                input = Console.ReadLine()[0];
                if (input != '1' && input != '2' && input != 'q')
                    Console.WriteLine("\nEnter a valid value: ");
            }

            if ( input == '1' )
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

            dmg = rand.Next(1, 5);

            enemy = new RPG.Skeleton(65, 12);
            enemy1 = new RPG.Giant(65, 12);
            enemy2 = new RPG.Ogre(65, 12);
            enemy3 = new RPG.Orc(65, 12);
            enemy4 = new RPG.Troll(65, 12);

            if (dmg == 1)
            {
                Console.WriteLine("You encounter a {0}.\n", enemy.name);

                while (enemy.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();

                    while(input != '1' && input != '2' && input != 'q' )
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy.name, dmg);

                        if (enemy.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy.name);
                        }
                    }
                    else
                        goto end;
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

                while (enemy2.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy2.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy2.name, dmg);

                        if (enemy2.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy2.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy2.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy2.name);
                        }
                    }
                    else
                        goto end;
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

                while (enemy3.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy3.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy3.name, dmg);

                        if (enemy3.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy3.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy3.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy3.name);
                        }
                    }
                    else
                        goto end;
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

                while (enemy4.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy4.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy4.name, dmg);

                        if (enemy4.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy4.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy4.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy4.name);
                        }
                    }
                    else
                        goto end;
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
                Console.WriteLine("You encounter a {0}.\n", enemy1.name);

                while (enemy1.health > 0 && player.health > 0 && input != 'q')
                {
                    input = 'a';
                    PrintMenu();
                    while (input != '1' && input != '2' && input != 'q')
                    {
                        input = Console.ReadLine()[0];
                        if (input != '1' && input != '2' && input != 'q')
                            Console.WriteLine("\nEnter a valid value: ");
                    }

                    if (input == '1')
                    {
                        dmg = rand.Next(0, player.dmg);

                        enemy1.TakeDamage(dmg);
                        Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy1.name, dmg);

                        if (enemy1.health <= 0)
                            break;

                        dmg = rand.Next(0, enemy1.dmg);

                        player.TakeDamage(dmg);
                        Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                    }
                    else if (input == '2')
                    {
                        dmg = rand.Next(1, 10);
                        if (dmg >= 3)
                            Console.WriteLine("You dodged the attack from the {0}\n\n", enemy1.name);
                        else
                        {
                            Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy1.name);
                        }
                    }
                    else
                        goto end;
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
                "and find another\nlocation filled with armor and items from past adventurers");

            input = 'a';

            SearchPrintMenu();
            while (input != '1' && input != '2' && input != 'q')
            {
                input = Console.ReadLine()[0];
                if (input != '1' && input != '2' && input != 'q')
                    Console.WriteLine("\nEnter a valid value: ");
            }

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

            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();

            Console.WriteLine("You continue following the path on the map. As you approach a giant door, you look down and" +
                " see that you have\nreached the final room where the treasure should be stored. You push the door open with" +
                " a loud creak. You look\naround and see piles of gold and a giant gold suit of armor. Suddenly, you see" +
                " movement out of the corner of your\neye.You rush to take cover as flames are shot in your direction.");

            var enemy5 = new RPG.Dragon(85, 17, "fire");
            Console.WriteLine("You encounter a {0}.\n", enemy5.name);

            while (enemy5.health > 0 && player.health > 0 && input != 'q')
            {
                input = 'a';
                PrintMenu();
                while (input != '1' && input != '2' && input != 'q')
                {
                    input = Console.ReadLine()[0];
                    if (input != '1' && input != '2' && input != 'q')
                        Console.WriteLine("\nEnter a valid value: ");
                }

                if (input == '1')
                {
                    dmg = rand.Next(0, player.dmg);

                    enemy5.TakeDamage(dmg);
                    Console.WriteLine("You hit the {0} for {1} attack points.\n", enemy5.name, dmg);

                    if (enemy5.health <= 0)
                        break;

                    dmg = rand.Next(0, enemy5.dmg);

                    player.TakeDamage(dmg);
                    Console.WriteLine("You were hit for {0} attack points by the {1}.\n\n", dmg, enemy5.name);
                }
                else if (input == '2')
                {
                    dmg = rand.Next(1, 10);
                    if (dmg >= 3)
                        Console.WriteLine("You dodged the attack from the {0}\n\n", enemy5.name);
                    else
                    {
                        Console.WriteLine("You dodged the wrong way and were hit for {0} attack points by the {1}.\n\n", dmg, enemy5.name);
                    }
                }
                else
                    goto end;
            }

            if (enemy5.health <= 0)
            {
                Console.WriteLine("You have defeated the {0}.\nYou put on the gold suit of armor and stuff your backpack" +
                    "with as much gold as you can carry. Backtracking your path, you make it back out of the dungeon.\n" +
                    "Everyone in the vilage sees you return and celebrate.\nCongratulations, you won with {1} health" +
                    " left!", enemy5.name, player.health);
            }
            else if (player.health <= 0)
            {
                Console.WriteLine("You have been defeated by the {0}.\nYou have lost the game.\n", enemy5.name);
                goto end;
            }
            else
                goto end;

        end:;
            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();
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
