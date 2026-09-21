using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int playerScore = 0;
        int enemyScore = 0;

        while (playerScore < 3 && enemyScore < 3)
        {
             Console.WriteLine();
             Console.WriteLine("1 = sword");
             Console.WriteLine("2 = shield");
             Console.WriteLine("3 = magic");

          Console.Write("choose: ");

              int player;

             try
            {
                player = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("enter a number");
                continue;
            }

             if (player < 1 || player > 3)
            {
                Console.WriteLine("pick 1, 2 or 3");
                continue;
            }

            int enemy = random.Next(1, 4);

            if (enemy == 1)
            {
                Console.WriteLine("enemy chose sword");
            }
            else if (enemy == 2)
            {
              Console.WriteLine("enemy chose shield");
            }
            else
            {
                 Console.WriteLine("enemy chose magic");
             }

            if (player == enemy)
            {
                Console.WriteLine("draw");
            }
            else if (
              player == 1 && enemy == 3 ||
                  player == 2 && enemy == 1 ||
                player == 3 && enemy == 2)
            {
                  Console.WriteLine("you win the round");
                playerScore++;
            }
            else
            {
                  Console.WriteLine("enemy wins the round");
              enemyScore++;
            }

              Console.WriteLine();
              Console.WriteLine("you: " + playerScore);
              Console.WriteLine("enemy: " + enemyScore);
        }

        if (playerScore == 3)
        {
            Console.WriteLine("you won the battle");
        }
        else
        {
              Console.WriteLine("you lost the battle");
        }

          Console.ReadLine();
    }
}