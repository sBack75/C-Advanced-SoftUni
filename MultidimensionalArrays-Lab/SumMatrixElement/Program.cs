using System;
using System.Linq;

namespace SumMatrixElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = command[0];
            int col = command[1];
            int[,] myFirstMultiArr = new int[rows, col];

            
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine()
                   .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
                for (int colomn = 0; colomn < col; colomn++)
                {

                    myFirstMultiArr[row, colomn] = arr[colomn];
                   
                }
            }

            foreach (var item in myFirstMultiArr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
