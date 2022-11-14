using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MVCclassRoster.RosterModel;

namespace MVCclassRoster
{
    class RosterController
    {
        private RosterModel model;
        private RosterView view;

        bool endApp = false;

        public RosterController()
        {
            string input = "";

            while (!endApp)
            {
                model = new RosterModel();
                view = new RosterView();

                view.printString("Class Roster in C#");
                view.printString("------------------");

                input = view.printOperations();

                model.doOperations(input);

                if(input == "q")
                {
                    endApp = true;
                }  
                   
            }
        }
    }
}
