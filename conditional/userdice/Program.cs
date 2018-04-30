using System;

namespace userdice
{
    class Program
    {
        //Many role−playing games require dice with a different number of faces than the traditional
        //six−sided cube.Write a program that asks the user how many sides the die should have,
        //and give a random result in the appropriate range.
        
        static void Main(string[] args)
        {
            Console.WriteLine("How amny dice face do you want in your game");
            int diceFace = Convert.ToInt32(Console.ReadLine());
            int result;

            Random toss = new Random();
            result = (int)(toss.NextDouble() * diceFace) + 1;
            Console.WriteLine("Dice face number {0}",result);
            Console.ReadKey();
        }
    }
}
