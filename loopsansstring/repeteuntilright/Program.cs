using System;

namespace repeteuntilright
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int temp;
            int ans;
            Random sol = new Random();
            num1 = (int)(sol.NextDouble() * 20) + 1;
            num2 = (int)(sol.NextDouble() * 20) + 1;
            ans = num1 + num2;
            Console.WriteLine("{0}+{1}=", num1, num2);
            temp = Convert.ToInt32(Console.ReadLine());
            while (ans != temp)
            {
                if (ans == temp)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("{0}+{1}=", num1, num2);
                    temp = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
