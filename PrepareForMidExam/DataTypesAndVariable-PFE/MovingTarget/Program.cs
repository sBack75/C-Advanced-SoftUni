using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "End")
                {
                    break;
                }
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);


                if (command[0] == "Shoot")
                {
                    listOfNumbers = Shoot(listOfNumbers, index, value);
                }
                else if (command[0] == "Add")
                {
                    listOfNumbers = Add(listOfNumbers, index, value);
                }
                else if (command[0] == "Strike")
                {
                    listOfNumbers = Strike(listOfNumbers, index, value);
                }
            }
            Console.WriteLine(string.Join('|',listOfNumbers));

        }

        static List<int> Shoot (List<int> numbers , int index , int value)
        {
            if (numbers.Count > index)
            {
                if (numbers[index] - value > 0)
                {
                    numbers[index] -= value;
                }
                else if (numbers[index] - value <= 0)
                {
                    numbers.RemoveAt(index);
                }
                return numbers;
            }
            else
            {
                return numbers;
            }
        }
        static List<int> Add(List<int> numbers , int index , int value) 
        {
            if (numbers.Count > index)
            {
                numbers.Insert(index, value);
                return numbers;
            }
            else
            {
                Console.WriteLine("Invalid placement!");
                return numbers;
            }

        }
        static List<int> Strike(List<int>numbers , int index , int radius)
        {
            if (numbers.Count > index + radius && index - radius >= 0)
            {
                
                int curIndex = index;
                for (int i = curIndex+1; i <= index + radius; i++)
                {
                    numbers.RemoveAt(i);             
                }
                for (int i = curIndex; i >= index - radius; i--)
                {
                    numbers.RemoveAt(i);

                }
                return numbers;
            }
            else
            {
                Console.WriteLine("Strike missed!");
                return numbers;
            }
        }
    }
}
