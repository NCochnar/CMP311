//Nathan Cochnar: Activity5 CMP311

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster
{
    class Student : Person
    {
        private string classRank;


        public Student() : base()
        {
            classRank = "";
        }

        public Student(string newFirstName, string newLastName, string newClassRank): base(newFirstName, newLastName)
        {
            classRank = newClassRank;
        }

        public string ClassRank
        {
            get { return classRank; }
            set { classRank = value; }
        }

        public override string ToString()
        {
            return this.Lastname + ", " + this.Firstname + ": " + this.ClassRank;
        }

    }


}
