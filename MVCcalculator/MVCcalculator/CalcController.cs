using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCcalculator
{
    class CalcController
    {
        private CalcModel model;
        private CalcView view;

        bool endApp = false;

        public CalcController()
        {
            while (!endApp)
            {

                model = new CalcModel();
                view = new CalcView();

                view.printString("Console Calculator in C#");

                model.Number1 = view.getDoubleFromUser();
                model.Number2 = view.getDoubleFromUser2();

                string selection = view.printOperations();
                double result = model.doOperations(selection);
                view.printTotal(result);

                view.quitOperations();
            }
        }
    }
}
