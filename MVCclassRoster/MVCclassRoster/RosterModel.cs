using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCclassRoster
{
    
        public class Person
        {
            private string firstname;
            private string lastname;

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

        public class Student : Person
        {
            private string classRank;

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

        public class Instructor : Person
        {
            private string contactInfo;

            public string ContactInfo
            {
                get { return contactInfo; }
                set { contactInfo = value; }
            }
            public override string ToString()
            {
                return this.Lastname + ", " + this.Firstname + ": " + this.ContactInfo;
            }
        }
    public class RosterModel
    {
        private List<Student> myList;
        private Instructor newInstructor;

        public RosterModel()
        {
            myList = new List<Student>();
            newInstructor = new Instructor();
        }


        public void doOperations(string operation)
        {
            if (operation == "s")
            {
                Student newStudent = new Student();
                Console.WriteLine("First name?");
                newStudent.Firstname = Console.ReadLine();
                if (newStudent.Firstname != String.Empty) 
                {
                    Console.WriteLine("Last name?");
                    newStudent.Lastname = Console.ReadLine();
                    if (newStudent.Lastname != String.Empty)
                    {
                        Console.WriteLine("Class Rank?");
                        newStudent.ClassRank = Console.ReadLine();

                        myList.Add(newStudent);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                Console.WriteLine(newStudent);
                Console.WriteLine(myList[0]);
            }

            else if (operation == "i")
            {
                Console.WriteLine("First name?");
                newInstructor.Firstname = Console.ReadLine();
                if (newInstructor.Firstname != String.Empty) 
                {
                    Console.WriteLine("Last name?");
                    newInstructor.Lastname = Console.ReadLine();
                    if (newInstructor.Lastname != String.Empty)
                    {
                        Console.WriteLine("Contact Information?");
                        newInstructor.ContactInfo = Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
            }
            else if (operation == "p")
            {
                Console.WriteLine("right here");
 ;
                Console.WriteLine(newInstructor);

                foreach (Student student in myList)
                {
                    Console.WriteLine(student);
                    Console.WriteLine("here");
                }
            }

        }
    }
}
