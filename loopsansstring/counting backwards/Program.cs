using System;

namespace counting_backwards
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Write("{0} \t",i);
            }
            Console.ReadKey();
        }
    }
}
