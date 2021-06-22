using System;
using System.Linq;

namespace SumbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] myMatrix = new char[matrixSize, matrixSize];
            bool checker = false;

            for (int rows = 0; rows < matrixSize; rows++)
            {
                char[] curData = Console.ReadLine().ToCharArray();
               
                    

                for (int column = 0; column < matrixSize; column++)
                {
                    myMatrix[rows, column] = curData[column];
                }
            }
            char searchSymbol = char.Parse(Console.ReadLine());
            string position = string.Empty;
            for (int rows = 0; rows < matrixSize; rows++)
            {
                for (int column = 0; column < matrixSize; column++)
                {
                    if (searchSymbol == myMatrix[rows, column] && checker == false)
                    {
                        position = $"({rows}, {column})";
                        checker = true;
                    }
                }
            }

            if (position == string.Empty)
            {
                Console.WriteLine($"{searchSymbol} does not occur in the matrix");
            }
            else
            {
                Console.WriteLine(position);
            }
        }
    }
}
