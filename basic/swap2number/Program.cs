using System;

namespace swap2number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b= Convert.ToInt32(Console.ReadLine());
            int temp;
            temp=a;
            a = b;
            b = temp;
            Console.WriteLine("now new value of a ={0}",a);
            Console.WriteLine("now new value of b ={0}", b);
            Console.ReadKey();
        }
    }
}
