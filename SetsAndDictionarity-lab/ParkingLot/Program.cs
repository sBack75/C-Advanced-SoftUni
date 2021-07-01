using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumber = new HashSet<string>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "END")
                {
                    break;
                }
                else if (command[0] == "OUT")
                {
                    string number = command[1];
                    carNumber.Remove(number);
                }
                else if (command[0] == "IN")
                {
                    string number = command[1];
                    carNumber.Add(number);
                }
            }

            if (carNumber.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in carNumber)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
