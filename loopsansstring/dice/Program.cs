//Write a program that asks a user how many dice to roll, rolls a six−sided die that many
//times, and returns the total and average roll.
using System;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //input from user
            Console.WriteLine("How many times dice you want to roll");
            int diceNumber = Convert.ToInt32(Console.ReadLine());
            int diceRoll = diceNumber;
            int diceAnswer;
            int count = 0;
            int totaloutput;
            int temp;

            //roll a dice
            for (int i = 1; i <= diceRoll; i++)
            {
                if (diceRoll > 1)
                {
                    Random roll = new Random();
                    diceAnswer = (int)(roll.NextDouble() * 6) + 1;
                    temp = diceAnswer;
                    totaloutput = diceAnswer + temp;
                    count++;
                    Console.WriteLine("total time the dice is rolled is {0} :", count);
                    Console.WriteLine("avarage of outputes is {0}", totaloutput / count);
                }
            }
            
            Console.ReadKey();
        }
    }
}
