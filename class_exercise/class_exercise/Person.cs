using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace class_exercise
{
    class Person
    {
        int age;
        string firstName, lastName;

        public int Age
        {
            get { return this.age; }
            set { this.age = value;  }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Person()
        {

        }

        public Person(int age, string firstName, string lastName)
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
        }



        public void DettaÄrJag()
        {
            Console.WriteLine("Hej jag heter " + (firstName ?? "[nobody]") + " " + (lastName ?? "[nobody]") + " och är " + age + " år gammal");
        }
    }
}
