using System;

namespace devide2result
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1st value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 1st value");
            int num2= Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter a 1st value");
            int num3= Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter a 1st value");
            int num4= Convert.ToInt32(Console.ReadLine()); ;
            double ans1;
            double ans2;
            double finalanswer;
            ans1 = num1 / num2;
            ans2 = num3 / num4;
            finalanswer = ans1 / ans2;
            Console.WriteLine("{0} divides {1} : {2}",num1,num2,ans1);
            Console.WriteLine("{0} divides {1} : {2}", num3, num4, ans2);
            Console.WriteLine("{0} divides {1} : {2}", ans1,ans2,finalanswer);
            Console.ReadKey();


        }
    }
}
