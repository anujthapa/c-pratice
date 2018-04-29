using System;

namespace avarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter nnd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 4th number");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int avarage;
            avarage = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The avarage of {0}, {1}, {2}, {3} is {4}",num1,num2,num3,num4,avarage);
            Console.ReadKey();




        }
    }
}
