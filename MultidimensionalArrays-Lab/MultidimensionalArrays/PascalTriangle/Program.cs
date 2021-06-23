using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int howLarge = int.Parse(Console.ReadLine());
            int[][] myJaggedArr = new int[howLarge][];


            myJaggedArr[0] = new int[1];
            myJaggedArr[0][0] = 1;



            
        }
    }
}
