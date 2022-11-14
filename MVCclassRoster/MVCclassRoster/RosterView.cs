using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCclassRoster
{
    class RosterView
    {
        public void printString(string itemToPrint)
        {
            Console.WriteLine(itemToPrint);
        }

        public string printOperations()
        {
            Console.WriteLine("Choose one of the following options:");

            Console.WriteLine("\ts - Add Student");
            Console.WriteLine("\ti - Add Instructor");
            Console.WriteLine("\tp - Print Class Roster");
            Console.WriteLine("\tq - Quit Application");
            Console.WriteLine("Your Option?");

            string input = Console.ReadLine();
            if (input == "s")
            {
                return input;
            }
            else if (input == "i")
            {
                return input;
            }
            else if (input == "p")
            {
                return input;
            }
            else if (input == "q")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return printOperations();
            }
        }

        public void printTotal(double result)
        {
            Console.WriteLine(Convert.ToString(result));
        }

        private static void quitOperations()
        {
            Console.WriteLine("Press Enter to continue, or q to quit");

            string input = Console.ReadLine();

            if (input == "q")
            {
                Environment.Exit(0);
            }
        }
    }
}
