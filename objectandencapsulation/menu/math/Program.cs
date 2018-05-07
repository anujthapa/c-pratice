using System;

namespace math
{
    class input
    {
        // variables
        private int pnum1;
        private int pnum2;
        

        //inilization num1
        public int num1
        {
            get
            {
                return pnum1;
            }
            set
            {
                pnum1 = value;
                
            }
        }

        //inilization num1
        public int num2
        {
            get
            {
                return pnum2;
            }
            set
            {
                pnum2 = value;
                
            }
          
        }
        // sum methord
        public int sum()
        {
            return pnum1 + pnum2;
        }

        //multiply menthord
        public int multiply()
        {
            return num1 * num2;
        }

        //divide mehtord
        public double divide()
        {
            return num1 / num2;
        }

        //mode methord
        public double mode()
        {
            return num2 % num1;
        }
        //sub methord
        public int sub()
        {
            return num1 - num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool continueprogram = true;
            int choice;
            

            input newanswers = new input();
            Console.WriteLine("Enter a value of num1");
            newanswers.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value of num2");
            newanswers.num2 = Convert.ToInt32(Console.ReadLine());
            while (continueprogram)
            {
                choice = showMenu();
                {
                    switch (choice)
                    {
                        case 0:
                            continueprogram = false;
                            break;
                        case 1:
                              Console.WriteLine("the sum is {0} : ",newanswers.sum());
                               break;
                        case 2:
                            Console.WriteLine("diffrence of two number is : {0}", newanswers.sub());
                            break;
                        case 3:
                            Console.WriteLine("division of 2 number is : {0}", newanswers.divide());
                            break;
                        case 4:
                            Console.WriteLine("multiplication of 2 number is {0}", newanswers.multiply());
                            break;
                        case 5:
                            Console.WriteLine("mode of 2 number is {0}", newanswers.mode());
                            break;

                        default:
                            Console.WriteLine("try again");
                            break;
                    }

                }

            }
        }
        static int showMenu()
        {
            int input = 1;
            Console.WriteLine("press 0 to exit");
            Console.WriteLine("press 1 to add number");
            Console.WriteLine("press 2 for substraction");
            Console.WriteLine("press 3 to divide");
            Console.WriteLine("press 4 to multiply");
            Console.WriteLine("press 5 to get mode");
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("no valid choice");
                input = 1;
            }
            return input;

        }
    }
}

