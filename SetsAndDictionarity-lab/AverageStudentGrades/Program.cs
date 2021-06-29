using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberStudents; i++)
            {
                string[] curData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = curData[0];
                double grades = double.Parse(curData[1]);
                List<double> mySecList = new List<double>();
                mySecList.Add(grades);
                if (students.ContainsKey(name) == true)
                {

                  
                    students[name].Add(grades);

                }
                else
                {
                    students.Add(name, mySecList);
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} {item.Value}");

               
            }
        }
    }
}
