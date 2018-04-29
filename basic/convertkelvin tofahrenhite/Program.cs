using System;

namespace convertkelvin_tofahrenhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount in celcus");
            double cel = Convert.ToDouble (Console.ReadLine());
            double far;
            far = cel*1.8;
            Console.WriteLine("{0} is {1}",cel,far);
            Console.ReadKey();

        }
    }
}
