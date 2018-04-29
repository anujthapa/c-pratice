using System;

namespace diffrentoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of X");
            int x = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter value of Y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value fo Z");
            int z = Convert.ToInt32(Console.ReadLine());
            int result1;
            int result2;

            result1 = (x + y) * z;
            result2 = (x * y) + (y*z);

            Console.WriteLine("{0} + {1} * {2} is: {3}",x,y,z,result1);
            Console.WriteLine("{0}.{1} + {1}.{2} is: {3}", x, y, z, result2);
            Console.ReadKey();
        }
    }
}
