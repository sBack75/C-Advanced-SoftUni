using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
          

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                int value = int.Parse(command);
                if (numbers.Length-1 < value)
                {
                    continue;
                }
                int curNumber = numbers[value];
                numbers[value] = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == value)
                    {
                        continue;
                    }
                    if (numbers[i] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        if (numbers[i] - curNumber <= 0)
                        {
                            numbers[i] = numbers[i] + curNumber;
                        }
                        else
                        {
                            numbers[i] = numbers[i] - curNumber;
                        }
                    }
                }
            }

            int[] curCount = numbers.Where(x => x == -1).ToArray();
            int counter = curCount.Length;
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(' ',numbers)}");

        }
    }
}
