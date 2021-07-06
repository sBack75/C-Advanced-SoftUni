using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] neiberhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int[] data = neiberhood
                .Select(int.Parse)
                .ToArray();
            int digit = 0;

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Love!")
                {
                    break;
                }

                else if (command[0] == "Jump")
                {
                     digit += int.Parse(command[1]);

                    for (int i = 0; i <= digit; i++)
                    {
                        if (digit > data.Length-1)
                        {
                            digit = 0;
                            i = -1;
                            continue;
                        }
                        else
                        {
                            if (data[digit] > 0)
                            {
                                data[digit] -= 2;
                                if (data[digit] <= 0)
                                {
                                    Console.WriteLine($"Place {digit} has Valentine's day.");
                                }
                                break;

                            }
                            else
                            {
                                Console.WriteLine($"Place {i} already had Valentine's day.");
                                break;
                            }
                        }
                    }
                }

            }
            int[] failed = data.Where(x => x > 1).ToArray();
            Console.WriteLine($"Cupid's last position was {digit}.");
            Console.WriteLine($"Cupid has failed {failed.Length} places.");
                
        }
    }
}
