using System;

namespace position_change
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "hari";
            string lname = "panday";
            char s = fname[0];
            string fullname = fname + lname;
            Console.WriteLine(change_char(fullname));
            Console.ReadKey();
            
        }
        public static  string change_char(string str) 
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
