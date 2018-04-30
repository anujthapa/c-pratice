using System;

namespace textchanger
{
    class pigdata
    {
        static void Main(string[] args)
        {
            string sentence;
            string firstChar;
            string restOfWord;
            string pigWord;
            string vowels = "AEIOUaeiou";
            int letterpos;
            Console.WriteLine("Enter sentence you want to change in pigtext!");
            sentence = Console.ReadLine();
            foreach (string word in sentence.Split())
            {
                firstChar = word.Substring(0, 1);
                restOfWord = word.Substring(1, word.Length - 1);
                letterpos = vowels.IndexOf(firstChar);
                if(letterpos== -1)
                {
                    pigWord = restOfWord + firstChar + "ay";
                    
                }
                else
                {
                    pigWord = word + "way";
                }
                Console.Write(pigWord);

            }

            Console.ReadKey();

        }
    }
}
