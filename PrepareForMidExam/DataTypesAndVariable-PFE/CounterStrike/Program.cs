using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int intialEnergy = int.Parse(Console.ReadLine());
            int counterWin = 0;
            int threeWonCount = 0;
            bool winner = true;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of battle")
                {
                    break;
                }
                int curData = int.Parse(command);
                

                if (intialEnergy - curData >=     0)
                {
                    counterWin++;
                    threeWonCount++;
                    intialEnergy -= curData;
                }
                else
                {
                    winner = false;
                    Console.WriteLine($"Not enough energy! Game ends with {counterWin} won battles and {intialEnergy} energy");
                    break;
                }
                if (threeWonCount == 3)
                {
                    intialEnergy += counterWin;
                    threeWonCount = 0;
                }
            }


            if (winner == true)
            {
                Console.WriteLine($"Won battles: {counterWin}. Energy left: {intialEnergy}");
            }
        }
    }
}
