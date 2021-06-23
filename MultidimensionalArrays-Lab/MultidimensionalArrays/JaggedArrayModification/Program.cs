using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsSize = int.Parse(Console.ReadLine());
            int[][] myJaggedArr = new int[rowsSize][];

            for (int rows = 0; rows < rowsSize; rows++)
            {
                int[] curData = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
                myJaggedArr[rows] = new int[curData.Length];
                for (int col = 0; col < rowsSize; col++)
                {
                    myJaggedArr[rows][col] = curData[col];
                }
            }

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "END")
            {

                int rows = int.Parse(command[1]);
                int column = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (rows > rowsSize-1 || column > rowsSize-1 || rows < 0 || column < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
                    continue;
                }
                if (command[0] == "Add")
                {
                    rows = int.Parse(command[1]);
                    column = int.Parse(command[2]);
                    value = int.Parse(command[3]);

                    myJaggedArr[rows][column] = myJaggedArr[rows][column] + value;


                }
                else if (command[0] == "Subtract")
                {
                    rows = int.Parse(command[1]);
                    column = int.Parse(command[2]);
                    value = int.Parse(command[3]);

                    myJaggedArr[rows][column] = myJaggedArr[rows][column] - value;
                }
                command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            for (int row = 0; row < rowsSize; row++)
            {
                for (int column = 0; column < rowsSize; column++)
                {
                    Console.Write($"{myJaggedArr[row][column]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
