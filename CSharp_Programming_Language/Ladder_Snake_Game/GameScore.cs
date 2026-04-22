using System;
using System.Collections.Generic;
using System.Text;
using CSharp_Programming_Language.Ladder_Snake_Game;

namespace CSharp_Programming_Language.Ladder_Snake_Game
{

    public class GameScore
    {
        public void GameLogic()
        {
            Console.WriteLine("Enter No of Player");
            int noOfPlayer;
            while (int.TryParse(Console.ReadLine(), out noOfPlayer))
            {
                if (noOfPlayer >= 2 && noOfPlayer <= 4)
                {
                    break;
                }
                else
                    Console.WriteLine("invalid input!");
            }

            List<Player> player = new List<Player>();

            Dictionary<int, int> snake = new Dictionary<int, int>()
            {
                {17, 7},
                {62, 19},
                {64, 60},
                {87, 24},
                {93, 73},
                {95, 75},
                {99, 78}
            };

            Dictionary<int, int> ladders = new Dictionary<int, int>()
            {
                {4, 14},
                {9, 31},
                {20, 38},
                {28, 84},
                {40, 59},
                {63, 81}
            };


            for (int i=0;i<noOfPlayer;i++)
            {
                Console.WriteLine("Enter Player Name");
                string name = Console.ReadLine();

                player.Add(new Player(name, i));
            }

            Random random = new Random();

            while (true)
            {
                for (int i = 0; i < noOfPlayer; i++)
                {
                    int dice = random.Next(1, 7);
                    Console.WriteLine($"dice score: {dice}");

                    Console.WriteLine($"Player: {player[i].Name}");
                    Console.WriteLine($"Previous score: {player[i].Score}");

                    if (player[i].Score + dice > 100)
                    {
                        Console.WriteLine("Move skipped because greater than 100");
                        continue;
                    }

                    player[i].Score += dice;

                  
                    if (snake.ContainsKey(player[i].Score))
                    {
                        Console.WriteLine("Bitten by snake");
                        player[i].Score = snake[player[i].Score];
                    }

                    
                    if (ladders.ContainsKey(player[i].Score))
                    {
                        Console.WriteLine("jump/climp ladder");
                        player[i].Score = ladders[player[i].Score];
                    }

                    Console.WriteLine($"New score: {player[i].Score}");

                    if (player[i].Score == 100)
                    {
                        Console.WriteLine($"Winner: {player[i].Name}\nThank you");
                        return;
                    }
                }
            }
        }
    }
}
