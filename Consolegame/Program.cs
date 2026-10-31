using System;
using System.Threading;

class Program
{
    static void Main()
    {
        say("welcome");

        Console.WriteLine(@"
========================
   THE LAST RUNEBLADE
========================

            /\
            ||
            ||
         ___||___
            ||
            ||
           /__\
");

        pause(4000);
        Console.Clear();

        Console.Write("enter your name: ");
        string name = Console.ReadLine();

        say("welcome " + name);
        pause(1500);

        Console.Clear();

        say("A small figure runs across a rocky mountain path...");
        pause(2000);

        say("They suddenly disappear over the edge.");
        pause(2000);

        Console.Clear();

        say("You wake up inside a dark cave beside a dying fire.");
        pause(2200);

        say("A cloaked figure turns the corner.");
        pause(1800);

        say("\"So, you're awake...\"");
        pause(1800);

        say("You try to stand, but your legs give out.");
        pause(1800);

        say("\"Don't. Your treatment isn't finished.\"");
        pause(2000);

        say("The figure removes their hood, revealing an old, withered woman.");
        pause(2200);

        say("She begins treating your wounds with herbs and strange liquids.");
        pause(2200);

        say("\"The kingdom isn't safe anymore. Not under our new 'king'.\"");
        pause(2400);

        say("She places an old sword beside you.");
        pause(1800);

        say("\"Being saved by a witch comes with a price.\"");
        pause(2200);

        say("\"My magic is keeping you alive. Do what I ask, or it won't for long.\"");
        pause(2500);

        say(name + ": What do you want?");
        pause(1800);

        say("\"Find the king. End his rule.\"");
        pause(2200);

        say(name + ": With this old sword?");
        pause(1800);

        say("The witch looks down at it.");
        pause(1800);

        say("\"No.\"");
        pause(1200);

        say("\"There is another weapon.\"");
        pause(1800);

        say("\"The Runeblade.\"");
        pause(2000);

        say("\"Find it. You will need it if you want any chance against the king.\"");
        pause(2400);

        Console.Clear();

        say("You received: OLD SWORD");
        pause(1800);

        say("\"Before you leave, you should probably remember how to fight.\"");
        pause(2000);

        say("\"Your sword and magic both deal damage.\"");
        pause(1800);

        say("\"Some enemies will be weaker to one than the other.\"");
        pause(2000);

        say("\"Your shield won't stop an attack completely, but it will hurt a lot less.\"");
        pause(2400);

        say("\"Try not to die.\"");
        pause(1800);

        say("A strange noise comes from the entrance of the cave...");
        pause(2000);

        say("A goblin runs into the cave!");
        pause(1800);

        say("\"Well... good timing.\"");
        pause(1500);

        bool won = combatStart("Goblin");

        if (won == false)
        {
            gameOver();
            return;
        }

        pause(2000);
        Console.Clear();

        say("\"Not bad.\"");
        pause(1500);

        say("\"Greyhaven is a few miles east of here.\"");
        pause(2000);

        say("\"Someone there might know more about the Runeblade.\"");
        pause(2200);

        say("You pick up the old sword and leave the cave.");
        pause(2200);

        say("The mountain air is cold, but the path ahead is clear.");
        pause(2200);

        say("After walking for a while, you see lights in the distance.");
        pause(2200);

        say("You have reached Greyhaven.");
        pause(2200);

        Console.Clear();

        say("========================");
        say("       GREYHAVEN");
        say("========================");

        pause(2200);

        say("Greyhaven is a small town surrounded by old stone walls.");
        pause(2200);

        say("People move through the streets as you enter.");
        pause(1800);

        say("You make your way towards a small inn.");
        pause(2000);

        say("An old man behind the counter notices your sword.");
        pause(2000);

        say("\"You don't look like you're from around here.\"");
        pause(2000);

        say(name + ": I'm looking for something called the Runeblade.");
        pause(2200);

        say("The old man stops what he is doing.");
        pause(1800);

        say("\"Haven't heard that name in years.\"");
        pause(2000);

        say("\"There are some old ruins north of town.\"");
        pause(2000);

        say("\"People used to say a strange sword was hidden there.\"");
        pause(2200);

        say("\"Nobody goes there anymore though.\"");
        pause(1800);

        say(name + ": Why?");
        pause(1500);

        say("\"People who go there don't usually come back.\"");
        pause(2200);

        say("You thank him and leave the inn.");
        pause(1800);

        Console.Clear();

        say("========================");
        say("       THE RUINS");
        say("========================");

        pause(2200);

        say("You leave Greyhaven and follow an old path north.");
        pause(2200);

        say("After a long walk, broken stone walls appear in the distance.");
        pause(2200);

        say("You have reached the ruins.");
        pause(1800);

        say("Most of the buildings have completely collapsed.");
        pause(2000);

        say("You walk deeper inside.");
        pause(1800);

        say("Something moves behind one of the broken walls.");
        pause(1800);

        say("A skeleton walks out from the ruins...");
        pause(1800);

        won = combatStart("Skeleton");

        if (won == false)
        {
            gameOver();
            return;
        }

        pause(1800);

        say("The skeleton falls apart.");
        pause(1800);

        say("You continue deeper into the ruins.");
        pause(2000);

        say("At the centre you find a staircase leading underground.");
        pause(2200);

        say("You walk down into a dark stone room.");
        pause(2200);

        say("At the other end of the room is an old stone altar.");
        pause(2200);

        say("A sword rests on top of it.");
        pause(2200);

        say("Unlike everything else here, the blade looks almost untouched.");
        pause(2400);

        say(name + ": The Runeblade...");
        pause(2000);

        say("You slowly lift the sword from the altar.");
        pause(2400);

        Console.Clear();

        say("========================");
        say(" YOU FOUND THE RUNEBLADE");
        say("========================");

        pause(2400);

        say("The blade feels strangely warm in your hands.");
        pause(2200);

        say("Faint markings along the blade begin to glow.");
        pause(2400);

        say("Then you hear footsteps behind you.");
        pause(1800);

        say("You turn around.");
        pause(1500);

        say("Several goblins are standing at the entrance.");
        pause(2200);

        say("There are too many to fight.");
        pause(1800);

        say("One of them throws something at you.");
        pause(1800);

        say("Everything goes dark.");
        pause(3000);

        Console.Clear();

        say("...");
        pause(1800);

        say("You slowly wake up.");
        pause(1800);

        say("Your head is pounding.");
        pause(1800);

        say("Your hands are tied tightly with rope.");
        pause(2000);

        say("The Runeblade is gone.");
        pause(1800);

        say("Two goblins are dragging you through the forest.");
        pause(2200);

        say("\"Boss gonna like this one.\"");
        pause(1800);

        say("\"And shiny sword!\"");
        pause(1800);

        say("You try to pull away, but the ropes are too tight.");
        pause(2200);

        say("The goblins drag you into a large camp.");
        pause(2200);

        say("Other goblins gather around.");
        pause(1800);

        say("Then the ground begins to shake.");
        pause(1800);

        say("THUD.");
        pause(1200);

        say("THUD.");
        pause(1200);

        say("The goblins suddenly go quiet.");
        pause(1800);

        say("A massive troll walks out from between the trees.");
        pause(2400);

        say("It carries a huge wooden club.");
        pause(2000);

        say("One of the goblins holds up the Runeblade.");
        pause(2000);

        say("\"Boss! We bring sword!\"");
        pause(1800);

        say("The troll takes the Runeblade.");
        pause(1800);

        say("It looks at the blade for a moment.");
        pause(1800);

        say("Then it looks down at you.");
        pause(2000);

        say("\"Human weak.\"");
        pause(1800);

        say("The troll throws the Runeblade onto the ground nearby.");
        pause(2000);

        say("It grabs its huge club.");
        pause(1800);

        say("You pull as hard as you can against the rope.");
        pause(1800);

        say("CRACK!");
        pause(1200);

        say("The rope snaps.");
        pause(1500);

        say("You jump to your feet.");
        pause(1600);

        say("You have no weapon.");
        pause(1600);

        say("The troll raises its club.");
        pause(1800);

        trollFight();

        pause(2200);
        Console.Clear();

        say("The troll crashes to the ground.");
        pause(2200);

        say("The goblins stare at you.");
        pause(1800);

        say("Then they begin running.");
        pause(1800);

        say("Within seconds the camp is almost empty.");
        pause(2200);

        say("You look down at the Runeblade.");
        pause(1800);

        say("The markings along the blade are glowing brighter than before.");
        pause(2200);

        say("You leave the goblin camp before any of them return.");
        pause(2200);

        Console.Clear();

        say("You continue along the road.");
        pause(2000);

        say("The forest slowly begins to thin.");
        pause(2000);

        say("Greyhaven is now far behind you.");
        pause(2000);

        say("You don't know exactly what waits ahead.");
        pause(2000);

        say("But the road continues deeper into the kingdom.");
        pause(2200);

        say("After several hours of walking, you see buildings in the distance.");
        pause(2400);

        say("Another town.");
        pause(1800);

        say("Much larger than Greyhaven.");
        pause(2200);

        say("You tighten your grip on the Runeblade and continue towards it.");
        pause(2500);

        Console.Clear();

        say("========================");
        say("     TO BE CONTINUED");
        say("========================");

        Console.ReadLine();
    }

    static bool combatStart(string enemyType)
    {
        int playerHealth = 20;

        int enemyHealth = 15;
        int enemyDamage = 3;

        int swordDamage = 4;
        int magicDamage = 4;

        if (enemyType == "Goblin")
        {
            enemyHealth = 15;
            enemyDamage = 3;

            swordDamage = 6;
            magicDamage = 3;
        }
        else if (enemyType == "Skeleton")
        {
            enemyHealth = 18;
            enemyDamage = 4;

            swordDamage = 3;
            magicDamage = 6;
        }

        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine("  BATTLE START");
        Console.WriteLine("================");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine();

            Console.WriteLine("YOU: " + playerHealth + " HP");
            Console.WriteLine(enemyType + ": " + enemyHealth + " HP");

            Console.WriteLine();

            Console.WriteLine("1 = Sword");
            Console.WriteLine("2 = Magic");
            Console.WriteLine("3 = Shield");

            Console.Write("Choose: ");

            int choice;

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter 1, 2 or 3");
                continue;
            }

            if (choice == 1)
            {
                enemyHealth = enemyHealth - swordDamage;

                Console.WriteLine("You attack with your sword!");
                Console.WriteLine("You dealt " + swordDamage + " damage");
            }
            else if (choice == 2)
            {
                enemyHealth = enemyHealth - magicDamage;

                Console.WriteLine("You use magic!");
                Console.WriteLine("You dealt " + magicDamage + " damage");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You raise your shield.");
            }
            else
            {
                Console.WriteLine("Enter 1, 2 or 3");
                continue;
            }

            if (enemyHealth <= 0)
            {
                enemyHealth = 0;
                break;
            }

            int damageTaken = enemyDamage;

            if (choice == 3)
            {
                damageTaken = enemyDamage / 2;

                if (damageTaken < 1)
                {
                    damageTaken = 1;
                }

                Console.WriteLine("Your shield reduces the damage.");
            }

            Console.WriteLine(enemyType + " attacks for " + damageTaken + " damage.");

            playerHealth = playerHealth - damageTaken;

            if (playerHealth < 0)
            {
                playerHealth = 0;
            }
        }

        Console.WriteLine();

        if (playerHealth > 0)
        {
            Console.WriteLine("You defeated the " + enemyType + "!");
            return true;
        }
        else
        {
            Console.WriteLine("You were defeated...");
            return false;
        }
    }

    static void trollFight()
    {
        Random random = new Random();

        bool trollDefeated = false;

        while (trollDefeated == false)
        {
            int dodgeHealth = 3;
            int dodges = 0;

            Console.Clear();

            say("========================");
            say("      TROLL FIGHT");
            say("========================");

            pause(1500);

            say("You have no weapon.");
            pause(1400);

            say("Survive long enough to reach the Runeblade.");
            pause(2000);

            while (dodgeHealth > 0 && dodges < 5)
            {
                Console.WriteLine();

                int attack = random.Next(1, 4);

                if (attack == 1)
                {
                    say("The troll swings its club!");
                    say("PRESS A TO DODGE!");

                    bool dodged = timedKey(ConsoleKey.A);

                    if (dodged == true)
                    {
                        say("You dodged!");
                        dodges++;
                    }
                    else
                    {
                        say("The club hits you!");
                        dodgeHealth--;
                    }
                }
                else if (attack == 2)
                {
                    say("The troll slams its club towards you!");
                    say("PRESS D TO DODGE!");

                    bool dodged = timedKey(ConsoleKey.D);

                    if (dodged == true)
                    {
                        say("You dodged!");
                        dodges++;
                    }
                    else
                    {
                        say("The troll hits you!");
                        dodgeHealth--;
                    }
                }
                else
                {
                    say("The troll swings straight at you!");
                    say("PRESS S TO DODGE!");

                    bool dodged = timedKey(ConsoleKey.S);

                    if (dodged == true)
                    {
                        say("You dodge backwards!");
                        dodges++;
                    }
                    else
                    {
                        say("The troll hits you!");
                        dodgeHealth--;
                    }
                }

                Console.WriteLine();

                say("Health: " + dodgeHealth);
                say("Dodges: " + dodges + "/5");

                pause(1000);
            }

            if (dodgeHealth <= 0)
            {
                Console.Clear();

                say("The troll knocks you to the ground.");
                pause(1800);

                say("RESTARTING TROLL FIGHT...");
                pause(2500);

                continue;
            }

            Console.Clear();

            say("The troll attacks again.");
            pause(1600);

            say("You dodge underneath its club.");
            pause(1600);

            say("The troll loses its balance.");
            pause(1800);

            say("You see the Runeblade lying nearby.");
            pause(1800);

            say("You run towards it.");
            pause(1500);

            say("You grab the Runeblade.");
            pause(1800);

            Console.WriteLine();

            say("========================");
            say(" RUNEBLADE RECOVERED");
            say("========================");

            pause(2000);

            say("The markings on the blade begin to glow.");
            pause(1800);

            say("The troll pulls its club free.");
            pause(1800);

            say("This time you can fight back.");
            pause(1800);

            bool won = trollCombat();

            if (won == true)
            {
                trollDefeated = true;
            }
            else
            {
                Console.Clear();

                say("The troll defeats you.");
                pause(1800);

                say("RESTARTING TROLL FIGHT...");
                pause(2500);
            }
        }
    }

    static bool timedKey(ConsoleKey correctKey)
    {
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }

        DateTime endTime = DateTime.Now.AddSeconds(2);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == correctKey)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Thread.Sleep(10);
        }

        return false;
    }

    static bool trollCombat()
    {
        int playerHealth = 20;
        int trollHealth = 30;

        while (playerHealth > 0 && trollHealth > 0)
        {
            Console.WriteLine();

            say("YOU: " + playerHealth + " HP");
            say("TROLL: " + trollHealth + " HP");

            Console.WriteLine();

            say("1 = Runeblade");
            say("2 = Magic");
            say("3 = Shield");

            Console.Write("Choose: ");

            int choice;

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                say("Enter 1, 2 or 3");
                continue;
            }

            if (choice == 1)
            {
                trollHealth = trollHealth - 8;

                say("You slash the troll with the Runeblade!");
                say("You dealt 8 damage.");
            }
            else if (choice == 2)
            {
                trollHealth = trollHealth - 5;

                say("You use magic!");
                say("You dealt 5 damage.");
            }
            else if (choice == 3)
            {
                say("You raise your shield.");
            }
            else
            {
                say("Enter 1, 2 or 3");
                continue;
            }

            if (trollHealth <= 0)
            {
                trollHealth = 0;
                break;
            }

            int damageTaken = 5;

            if (choice == 3)
            {
                damageTaken = 2;

                say("Your shield reduces the damage.");
            }

            playerHealth = playerHealth - damageTaken;

            if (playerHealth < 0)
            {
                playerHealth = 0;
            }

            say("The troll attacks for " + damageTaken + " damage.");
        }

        if (playerHealth > 0)
        {
            Console.Clear();

            say("The troll falls to its knees.");
            pause(1800);

            say("You raise the Runeblade.");
            pause(1500);

            say("You strike the troll one final time.");
            pause(2000);

            say("========================");
            say("     TROLL DEFEATED");
            say("========================");

            return true;
        }
        else
        {
            return false;
        }
    }

    static void gameOver()
    {
        Console.WriteLine();

        say("========================");
        say("       GAME OVER");
        say("========================");

        Console.ReadLine();
    }

    static void say(string text)
    {
        Console.WriteLine(text);
    }

    static void pause(int time)
    {
        Thread.Sleep(time);
    }
}