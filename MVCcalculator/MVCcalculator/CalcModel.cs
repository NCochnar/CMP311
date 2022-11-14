using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCcalculator
{
    class CalcModel
    {
        private double num1 = 0;
        private double num2 = 0;

        public double Number1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Number2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double doOperations(string operation)
        {
            if (operation == "a")
            {
                return num1 + num2;
            }

            else if(operation == "s")
            {
                return num1 - num2;
            }

            else if(operation == "m")
            {
                return num1 * num2;
            }

            else if(operation == "d")
            {
                return num1 / num2;
            }
            else
            {
                return 0;
            }
        }
    }
}
