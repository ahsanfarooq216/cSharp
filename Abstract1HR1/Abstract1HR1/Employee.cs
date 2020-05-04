using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract1HR1
{
    abstract class Employee
    {
        private string empNum;
        private string firstName;
        private string lastName;
        private string address;

        public string EmpNum
        {
            get { return empNum; }
            set { empNum = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public virtual void Login() //virtual means that this method MAY be overriden in subclass
        {
            Console.WriteLine("Employee login");
        }

        public abstract void Hire(); //abstract means that this method MUST be overriden in the subclass
    }
}
