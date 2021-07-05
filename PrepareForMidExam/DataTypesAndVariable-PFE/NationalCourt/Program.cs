using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEmployees = 0;

            for (int i = 0; i < 3; i++)
            {
                int curData = int.Parse(Console.ReadLine());
                totalEmployees += curData;
            }
            int clients = int.Parse(Console.ReadLine());
            int totalHour = 0;
            int counter = 0;

            while (clients > 0)
            {
                if (counter == 3)
                {
                    totalHour++;
                    counter = 0;
                    continue;
                }
                totalHour++;
                clients -= totalEmployees;
                counter++;

            }

            Console.WriteLine($"Time needed: {totalHour}");
        }
    }
}
