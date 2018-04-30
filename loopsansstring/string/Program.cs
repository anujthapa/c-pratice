using System;

namespace stringman
{
    class Program
    {
    static void Main(string[] args)
    {
        string thestring = "Welcome to c# pratice";
        Console.WriteLine("default: {0}", thestring);
        Console.WriteLine("lowercase: {0}", thestring.ToLower());
        Console.WriteLine("uppercase: {0}", thestring.ToUpper());
        Console.WriteLine("replace: {0}", thestring.Replace("#", "sharp"));
            Console.WriteLine("length:{0}",thestring.Length);
            Console.WriteLine("\"to\"is in the index: {0}",thestring.IndexOf("to"));
        Console.ReadLine();
    }
    }
}

