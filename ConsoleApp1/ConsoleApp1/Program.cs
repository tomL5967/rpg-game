using System;
using System.Threading;

class Program
{
    static Random random = new Random();
    static bool hasRuneblade = false;
    static int gold = 0;
    static bool fastText = false;

    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        titleArt();
        Console.ResetColor();
        caveArt();
        say("Disclaimer: This is a fictional game. Credit any outside art or sound you use.");

        say("1 = normal text speed");
        say("2 = fast text");
        fastText = choice(2) == 2;
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name)) name = "traveller";

        say("You fall from a mountain path and wake beside a dying fire.", 1200);
        say("A witch has treated your wounds. She gives you an old sword.", 1000);
        say("Witch: Find the Runeblade and stop the new king.", 1000);
        say(name + ": Why should I help you?");
        say("Witch: My magic is keeping you alive. Find the blade, then we can both be free.", 1000);
        say("She shows you how to fight: sword, magic, or shield.");

        if (!battle("goblin", 15, 3, 6, 3)) return;
        say("You leave the cave and head for Greyhaven.", 1000);
        say("At the town, you can visit the inn or the market.");
        say("1 = inn   2 = market");
        int townChoice = choice(2);
        if (townChoice == 1)
            say("Mara at the inn remembers stories about ruins north of town.");
        else
            say("Perrin at the market shows you an old map to the ruins.");

        say("You leave Greyhaven. A corrupt knight demands your gold.", 1000);
        say("1 = refuse and fight   2 = pay 2 gold");
        if (choice(2) == 2 && gold >= 2)
        {
            gold -= 2;
            say("You pay the knight and continue.");
        }
        else if (!battle("corrupt knight", 22, 4, 5, 6)) return;

        // A for loop runs two random encounters on the road.
        for (int i = 0; i < 2; i++)
        {
            string[] enemies = { "slime", "skeleton", "goblin" };
            string enemy = enemies[random.Next(enemies.Length)];
            say("On the road, a " + enemy + " attacks!");
            if (!battle(enemy, 16, 3, 5, 6)) return;
        }

        say("In the ruins, you find the Runeblade on a stone pedestal.", 1000);
        say("A Guardian Golem wakes and knocks your old sword away.", 1000);
        say("You reach the Runeblade just in time to block its next strike.", 1000);
        hasRuneblade = true;
        say("The blue runes glow. The Runeblade is yours.", 1000);
        if (!battle("Guardian Golem", 26, 5, 9, 3)) return;

        say("Wounded, you leave the ruins. Goblins ambush you and take your sword.", 1000);
        hasRuneblade = false;
        say("You wake in a cage at their camp. The guard looks away.", 1000);
        say("Press A within 3 seconds to slip out.");
        if (timedKey(ConsoleKey.A, 3))
            say("You slip free without being noticed.");
        else
        {
            say("The guard spots you. You have to fight!");
            if (!battle("goblin guard", 14, 3, 6, 3)) return;
        }
        say("The troll boss stands before your Runeblade.", 1000);
        if (!battle("troll boss", 30, 6, 7, 4)) return;

        hasRuneblade = true;
        say("You take back the Runeblade and escape the camp.", 1000);
        say("You return to the witch. Together, you travel to the castle.", 1000);
        say("The king's black crown protects him with magic.", 1000);
        if (!battle("King Aldren", 38, 5, 8, 4)) return;

        say("The Runeblade cracks the black crown and ends the king's spell.", 1000);
        say("The witch's magic releases you. Your life is your own again.", 1000);
        Console.ForegroundColor = ConsoleColor.Green;
        say("You win, " + name + "! Gold collected: " + gold);
        Console.ResetColor();
        say("Press Enter to finish.");
        Console.ReadLine();
    }

    // Battle repeats until someone runs out of health.
    static bool battle(string enemy, int enemyHP, int enemyDamage, int swordDamage, int magicDamage)
    {
        int startingEnemyHP = enemyHP;
        while (true)
        {
            int playerHP = hasRuneblade ? 25 : 20;
            enemyHP = startingEnemyHP;
            say("\nA " + enemy + " attacks!");
            enemyArt();

            while (playerHP > 0 && enemyHP > 0)
            {
                say("\nYour health: " + playerHP + " | " + enemy + " health: " + enemyHP);
                say("1 = sword/runeblade   2 = magic   3 = shield");
                int move = choice(3);

                // Switch chooses what your move does.
                switch (move)
                {
                    case 1:
                        int hit = hasRuneblade ? swordDamage + 3 : swordDamage;
                        enemyHP -= hit;
                        say("You hit for " + hit + " damage.");
                        break;
                    case 2:
                        enemyHP -= magicDamage;
                        say("Your magic hits for " + magicDamage + " damage.");
                        break;
                    case 3:
                        say("You block and watch the enemy's movements.");
                        say("Hint: " + (magicDamage > swordDamage ? "try magic." : "try your sword."));
                        break;
                }

                if (enemyHP <= 0) break;
                int damage = move == 3 ? Math.Max(1, enemyDamage / 2) : enemyDamage;
                playerHP -= damage;
                say(enemy + " hits you for " + damage + " damage.");
            }

            if (playerHP <= 0)
            {
                say("You were defeated. Retry this fight?");
                say("1 = retry   2 = quit");
                if (choice(2) == 1) continue;
                return false;
            }

            gold += random.Next(1, 4);
            say("You defeated the " + enemy + " and found some gold.");
            return true;
        }
    }

    // Do-while keeps asking until the player enters a valid menu number.
    static int choice(int max)
    {
        int answer;
        do
        {
            Console.Write("Choose 1-" + max + ": ");
            if (!int.TryParse(Console.ReadLine(), out answer)) answer = 0;
        }
        while (answer < 1 || answer > max);
        return answer;
    }

    static void titleArt()
    {
        Console.WriteLine("========================");
        Console.WriteLine("    THE LAST RUNEBLADE");
        Console.WriteLine("          /\\");
        Console.WriteLine("          ||");
        Console.WriteLine("        __||__");
        Console.WriteLine("          ||");
        Console.WriteLine("========================\n");
    }

    static void enemyArt()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("      (o_o)");
        Console.WriteLine("       /|\\");
        Console.WriteLine("       / \\");
        Console.ResetColor();
    }

    static void caveArt()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("      /\\      /\\");
        Console.WriteLine("     /  \\____/  \\");
        Console.WriteLine("    |     fire     |");
        Console.WriteLine("    |______________|");
        Console.ResetColor();
    }

    // This uses a short time limit and checks which key was pressed.
    static bool timedKey(ConsoleKey correctKey, int seconds)
    {
        DateTime deadline = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < deadline)
        {
            if (Console.KeyAvailable)
                return Console.ReadKey(true).Key == correctKey;
            Thread.Sleep(50);
        }
        return false;
    }

    // This method displays text and waits; delay is optional.
    static void say(string text, int delay = 0)
    {
        Console.WriteLine(text);
        if (!fastText && delay > 0) Thread.Sleep(delay);
    }
}



