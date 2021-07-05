using System;

namespace BonusScoringSystem_midExam
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal studentCount = decimal.Parse(Console.ReadLine());
            decimal lecturesCount = decimal.Parse(Console.ReadLine());
            decimal intialBonus = decimal.Parse(Console.ReadLine());
            decimal maxBonus = decimal.MinValue;
            int curLectors = 0;

            for (int i = 0; i < studentCount; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());

                decimal totalBonus = studentAttendances / lecturesCount ;
                totalBonus = totalBonus * (5 + intialBonus);
                totalBonus = Math.Round(totalBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    curLectors = studentAttendances;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {curLectors} lectures.");
        }
    }
}
