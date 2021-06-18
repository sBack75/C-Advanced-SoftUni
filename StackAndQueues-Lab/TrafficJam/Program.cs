using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passCar = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int crossRoadsCar = 0;

            while (true)
            {
                string carType = Console.ReadLine();
                if (carType == "end")
                {
                    break;
                }
                else if (carType == "green")
                {
                    if (cars.Count < passCar)
                    {
                        int forCount = cars.Count;
                        for (int i = 0; i < forCount; i++)
                        {
                            crossRoadsCar++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < passCar; i++)
                        {
                            crossRoadsCar++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                }
                else
                {
                    cars.Enqueue(carType);
                }
            }
            Console.WriteLine($"{crossRoadsCar} cars passed the crossroads.");
        }
    }
}
