using System;

namespace cointoss
{
    class Program
        //Write a program that simulates a coin toss. Generate a random number between 0 and 1. If
//that value is less than .5, make it heads.Otherwise, output tails
    {
        static void Main(string[] args)
        {
            int tossValue;

            Random toss = new Random();
            tossValue = (int)(toss.NextDouble() * 6) + 1;
            Console.WriteLine("Coin toss value is {0} ", tossValue);
            if (tossValue <= 5)
            {
                Console.WriteLine("head");
            }
            else
            {
                Console.WriteLine("tail");
            }
            Console.ReadKey();
        }
    }
}
