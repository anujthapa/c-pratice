using System;

namespace multiplediffrentnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of 1st number");
            int num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of 2nd nunber");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int answer = num1 * num2 * num3;
            Console.WriteLine("{0}x{1}x{2}={3}",num1,num2,num3,answer);
            Console.ReadKey();
        }
    }
}
