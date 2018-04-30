
using System;

namespace chorus
{
    class Program
    {
        static void doChorus(int verseNum)//mmethord o print a song
        {
            string message = "";
            message += "\n..With a knick-knick paddy whack\n";
            message += verseNum;
            message += "Give a dog a bone\n";
            message += "This old man came rolling home";
            message += getPlace(verseNum);
            Console.WriteLine(message);

          
            {
                
                switch (verseNum)
                {
                    case 1:
                        message = "om my thum";
                        break;
                    case 2:
                        message = "On my shoes";
                        break;
                    case 3:
                        message = "not yet defined";
                        break;

                }
            }
        }
        static void Main(string[] args)
        {
            
            doChorus(2);
            getPlace();
            Console.ReadKey();
        }
    }
}
