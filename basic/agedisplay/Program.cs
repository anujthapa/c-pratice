using System;

namespace agedisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You looks older than {0}",age);
            Console.ReadKey();
        }
    }
}
