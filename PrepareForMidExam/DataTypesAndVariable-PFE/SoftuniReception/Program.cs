using System;

namespace SoftuniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            short employeesFirst = short.Parse(Console.ReadLine());
            short employeesSecond = short.Parse(Console.ReadLine());
            short employeesThird = short.Parse(Console.ReadLine());
            int sumEmployees = employeesFirst + employeesSecond + employeesThird;
            int students = int.Parse(Console.ReadLine());
            short counter = 0;
            short breakFour = 0;

             while (students > 0)
            {
                if (breakFour == 3)
                {
                    counter++;
                    breakFour = 0;
                    continue;
                }

                if (students - sumEmployees > 0)
                {
                    students -= sumEmployees;
                    counter++;
                    breakFour++;
                }
                else if (sumEmployees - sumEmployees <= 0)
                {
                    counter++;
                    break;
                }
               
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
