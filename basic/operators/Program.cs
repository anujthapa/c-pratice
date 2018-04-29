using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} addition {1}={2}",num1,num2,num1+num2);
            Console.WriteLine("{0} substractoin {1}={2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} multiply {1}={2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} divides {1}={2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mode {1}={2}", num1, num2, num1 % num2);
            Console.ReadKey();

        }
    }
}
