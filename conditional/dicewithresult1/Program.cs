using System;

namespace dicewithresult1
{
    class Program
    {
        static void Main(string[] args)
        {
            int diceResult;
            int count=0;
            int dicecount=0;

            Random dice = new Random();
            diceResult = ((int)dice.NextDouble() * 6) + 1;
            dicecount++;
            if (diceResult == 1)
            {
                count++;
                if(count*2!=dicecount){
                    diceResult = ((int)dice.NextDouble() * 6) + 1;
                    
                }
                else
                {
                    Console.WriteLine(diceResult);
                }
            }
            
            Console.ReadKey();
            

        }
    }
}
