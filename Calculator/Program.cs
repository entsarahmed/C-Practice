using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num1;
            int Num2;
            string Answer;
            int Result = 0;
            Console.WriteLine("Please Enter Your First Number");
            Num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Second Number");
            Num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please, Enter + for addition, - for subtraction, * for multiplication or any other key for division.");
            Answer = Console.ReadLine();
            if (Answer == "+")
                Result = Num1 + Num2;
            else if (Answer == "-")
                Result = Num1 - Num2;
            else if (Answer == "/")
            {
                if (Num2 == 0)
                    Console.WriteLine("Please, you can't divide zero");
                else
                    Result = Num1 / Num2;
            }
            else
            {
                Result = Num1 * Num2;
               
            }
            Console.WriteLine("The result is " + Result);

        Console.ReadKey();

        }
    }
}
