//Nathan Cochnar: Activity5 CMP311

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace ClassRoster
{
    class Program
    {
        static void Main(string[]args)
        {
            Student myStudent1 = new Student("Nathan", "Cochnar", "Senior");
            Console.WriteLine(myStudent1);

            Student myStudent2 = new Student("Bob", "Miller", "Junior");
            Console.WriteLine(myStudent2);

            Instructor myInstructor1 = new Instructor("Alec", "Engebretson", "alec.engebretson@doane.edu");
            Console.WriteLine(myInstructor1);

            Instructor myInstructor2 = new Instructor("Mark", "Meysenburg", "mark.meysenburg@doane.edu");
            Console.WriteLine(myInstructor2);

            List<Student> myList = new List<Student>();
            Instructor newInstructor = new Instructor();

            bool run = true;
            while (run = true)
            {

                Console.WriteLine("-------------------");
                Console.WriteLine("Class Roster in c#");
                Console.WriteLine("------------------");
                Console.WriteLine("\ta - Add an Instructor");
                Console.WriteLine("\tb - Add a Student");
                Console.WriteLine("\tp - Print Class Roster");
                Console.WriteLine("\tq - End Application");
                string result = Console.ReadLine();

              
                if (result == "a")
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
                else if (result == "b")
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
                }
                else if (result == "p")
                {
                    Console.WriteLine(newInstructor);

                    foreach(Student student in myList)
                    {
                        Console.WriteLine(student);
                    }
                }

                else if (result == "q")
                {
                    run = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }

            }
        }
    }
}
