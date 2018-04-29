using System;

namespace removechar
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            Console.WriteLine(remove_char(x,1));
            Console.WriteLine(remove_char(x,9));
            Console.WriteLine(remove_char(x,0));
            Console.ReadKey();
        }
        public static string remove_char(string str,int i)
        {
            return str.Remove(i, 1);

        }
    }
}
