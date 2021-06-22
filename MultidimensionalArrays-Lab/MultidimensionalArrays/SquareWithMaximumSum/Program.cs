using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixSize[0];
            int column = matrixSize[1];
            int[,] myMatrix = new int[rows, column];

            for (int row = 0; row < rows; row++)
            {
                int[] curMatrixData = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < column; col++)
                {
                    myMatrix[row, col] = curMatrixData[col];
                }
            }
            List<int> result = new List<int>();
            int curValue = int.MinValue;
            string[] saveValues = new string[2];


            for (int row = 0; row < rows; row++)
            {
                int value = 0;
                List<int> curValueList = new List<int>();
                for (int col = 0; col < column; col++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        for (int s = 0; s < 1; s++)
                        {
                            if (row + 1 < row)
                            {
                                break;
                            }
                            else
                            {
                                value += myMatrix[row, col + i];
                                value += myMatrix[row, col + i+1];
                                curValueList.Add(myMatrix[row, col + i]);
                                curValueList.Add(myMatrix[row, col + i+1]);
                            }
                        }
                        
                    }
                    if (value > curValue)
                    {
                        curValue = value;
                        value = 0;
                        result = new List<int>(curValueList);
                        curValueList.Clear();
                    }
                    else
                    {
                        value = 0;
                        curValueList.Clear();
                    }
                }
            }
        }
    }
}
