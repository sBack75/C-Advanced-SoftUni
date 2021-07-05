using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] room = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int heroPower = 100;
            int totalCoins = 0;
            int theBestRoom = 0;
            bool winner = true;

            for (int i = 0; i < room.Length; i++)
            {
                string[] curCommand = room[i]
                    .Split(' ')
                    .ToArray();

                if (curCommand[0] == "potion")
                {
                    int potionFeed = int.Parse(curCommand[1]);
                    heroPower = Potion(heroPower, potionFeed);
                }
                else if (curCommand[0] == "chest")
                {
                    int coins = int.Parse(curCommand[1]);
                    totalCoins += coins;
                    Console.WriteLine($"You found {coins} bitcoins.");
                }
                else 
                {
                    int monsterDamage = int.Parse(curCommand[1]);
                    heroPower = Monster(heroPower, monsterDamage);

                    if (heroPower > 0)
                    {
                        Console.WriteLine($"You slayed {curCommand[0]}.");
                    }
                    else if (heroPower <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {curCommand[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        winner = false;
                        break;
                    }
                }
            }
            if (winner == true)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {totalCoins}");
                Console.WriteLine($"Health: {heroPower}");
            }
        }
        static int Potion(int power , int potionFeed)
        {
           
            if (power == 100)
            {
                Console.WriteLine($"Current health: {power} hp.");
                Console.WriteLine($"You healed for 0 hp.");
                return 100;
            }
            else if (power + potionFeed < 100)
            {
                Console.WriteLine($"You healed for {potionFeed} hp.");
                Console.WriteLine($"Current health: {power+potionFeed} hp.");

                return power + potionFeed;
            }
            else if (power + potionFeed > 100)
            {
                Console.WriteLine($"You healed for {100-power} hp.");
                Console.WriteLine($"Current health: 100 hp.");

                return 100;
            }
            return 0;
        }

        static int Monster(int heroHelth , int monsterDamage)
        {
            heroHelth = heroHelth - monsterDamage;
            return heroHelth;
        }
    }
}
