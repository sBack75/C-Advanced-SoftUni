using System;
using System.Linq;

namespace ArrayModificer
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();


            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                 if (command[0] == "decrease")
                {
                    numbers = numbers.Select(x => x - 1).ToArray();
                    continue;
                }
                int firstIndex = int.Parse(command[1]);
                int secondIndex = int.Parse(command[2]);

                if (command[0] == "swap")
                {
                    numbers = Swap(numbers, firstIndex, secondIndex);
                }
                else if (command[0] == "multiply")
                {
                    numbers = Multiply(numbers, firstIndex, secondIndex);
                }
                
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
        static int[] Swap (int[] numbers , int firstIndex , int secondIndex)
        {
            int firstElement = numbers[firstIndex];
            int secondElement = numbers[secondIndex];

            numbers[firstIndex] = secondElement;
            numbers[secondIndex] = firstElement;
            return numbers;
        }
        static int[] Multiply (int[]numbers , int firstIndex , int secondIndex)
        {
            int sum = numbers[firstIndex] * numbers[secondIndex];
            numbers[firstIndex] = sum;

            return numbers;
        }
    }
}
