using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < howMany; i++)
            {
                string[] curData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = curData[0];
                decimal mark = decimal.Parse(curData[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                    students[name].Add(mark);
                }
                else
                {
                    students[name].Add(mark);
                }
            }

            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");

                Console.Write(string.Join(' ',item.Value));
                Console.WriteLine($" (avg: {item.Value.Average():f2})");
            }
        }
    }
}
