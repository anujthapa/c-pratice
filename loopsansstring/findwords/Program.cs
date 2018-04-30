using System;

namespace findwords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "always count those fancy beans";
            foreach(string splitword in word.Split())
            {
                Console.WriteLine(splitword);
            }
            Console.ReadKey();
        }
    }
}
