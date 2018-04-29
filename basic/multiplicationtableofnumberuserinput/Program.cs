using System;

namespace multiplicationtableofnumberuserinput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int ans;
            for(int i = 0; i <= 10; i++)
            {
                ans = i * num1;
                Console.WriteLine("{0} X {1} = {2}", i, num1, ans);
            }
            Console.ReadKey();
        }
    }
}
