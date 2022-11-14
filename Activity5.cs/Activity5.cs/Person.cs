//Nathan Cochnar: Activity5 CMP311

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster
{
    class Person
    {
        private string firstname;
        private string lastname;

        public Person()
        {
            firstname = "";
            lastname = "";
        }

        public Person(string newFirstname, string newLastname)
        {
            firstname = newFirstname;
            lastname = newLastname;
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

    }
}
