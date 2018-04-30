using System;

namespace simplemathgame
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            double temp;
            int sum;
            int sub;
            double divide;
            double multiply;
            int count = 0;
            Random number = new Random();
            num1 = (int)(number.NextDouble()*20)+1;
            num2 = (int)(number.NextDouble()*20)+1;
            // sum
            sum = num1 + num2;
            Console.WriteLine("{0} + {1} = ", num1, num2);
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2,temp);
            if (sum == temp)
            {
                count++;
            }
        //substraction
            sub = num1 - num2;
            Console.WriteLine("{0} - {1} = ",num1,num2);
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} - {1} = {2}", num1, num2, temp);
            if(sub == temp)
            {
                count++;
            }

            // divide
            divide = num1 / num2;
            Console.WriteLine("{0} / {1} = ", num1, num2);
            temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} / {1} = {2}", num1, num2, temp);
            if (divide == temp)
            {
                count++;
            }

            //multiply
            multiply = num1 * num2;
            Console.WriteLine("{0} * {1} = ", num1, num2);
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", num1, num2, temp);
            if (multiply == temp)
            {
                count++;
            }
            Console.WriteLine("you have scored {0}",count);

            Console.ReadLine();
        }
    }
}
