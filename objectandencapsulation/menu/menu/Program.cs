using System;

namespace menu
{
    class Program
    {
        static int showMenu()
        {
            int input = 1;
            Console.WriteLine("0) Exit");
            Console.WriteLine("1) Listen to Critter");
            Console.WriteLine("2) Feed Critter");
            Console.WriteLine("3) Play with Critter");
            Console.WriteLine("4) Rename Critter");            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }            catch(FormatException)
            {
                Console.WriteLine("invalid input");
                input = 1;
            }            return input;
        }
        static void Main(string[] args)
        {
            
            bool keepgoing = true;
            int choice;
            while (keepgoing)
            {
                choice = showMenu();
                switch (choice)
                {
                    case 0:
                        keepgoing = false;
                        break;
                    case 1:
                        Console.WriteLine("You talk to the dog");
                        break;
                    case 2:
                        Console.WriteLine("You have feed dog");
                        break;
                    case 3:
                        Console.WriteLine("You played with dog");
                        break;
                    case 4:
                        Console.WriteLine("You have renamed dog");
                        break;
                    default:
                        Console.WriteLine("This is not valid input");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
