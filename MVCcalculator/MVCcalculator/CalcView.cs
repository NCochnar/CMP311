using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MVCcalculator
{
    class CalcView
    {
        public void printString(String itemToPrint)
        {
            Console.WriteLine(itemToPrint);
        }

        public double getDoubleFromUser()
        //Gets the first number from user
        {
            double i = 0;
            Console.WriteLine("Type a number, and then press Enter");
            var myNum = Console.ReadLine();
            bool passCheck = Double.TryParse(myNum, out i);
            if(passCheck)
            {
                return Convert.ToDouble(myNum);
            }
            return getDoubleFromUser();
        }

        public double getDoubleFromUser2()
        //Gets the second number from user
        {
            double i = 0;
            Console.WriteLine("Type another number, and then press Enter");
            var myNum = Console.ReadLine();
            bool passCheck = Double.TryParse(myNum, out i);
            if (passCheck)
            {
                return Convert.ToDouble(myNum);
            }
            return getDoubleFromUser2();
        }

        public void printNumber(double myNum1)
        {
            Console.WriteLine(Convert.ToString(myNum1));
        }

        public void printNumber2(double myNum2)
        {
            Console.WriteLine(Convert.ToString(myNum2));
        }

        public string printOperations()
        {
            Console.WriteLine("Choose an option from the following list:");

            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string input = Console.ReadLine();
            if (input == "a")
            {
                return input;
            }
            else if (input == "s")
            {
                return input;
            }
            else if (input == "m")
            {
                return input;
            }
            else if (input == "d")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return printOperations();
            }

        }
        public void printTotal(double result)
        {
            Console.WriteLine(Convert.ToString(result));
        }

        public void quitOperations()
        {
            Console.WriteLine("Press Enter to continue, or q to quit");

            string input = Console.ReadLine();

            if(input == "q")
            {
                Environment.Exit(0);
            }
        }
    }
}
