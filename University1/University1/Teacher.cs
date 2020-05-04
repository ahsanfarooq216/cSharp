using System;
using System.Collections.Generic;
using System.Text;

namespace University1
{
    class Teacher : Person
    {
        public string Designation { get; set; }
        public Teacher(string fName, string lName, string designation)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Designation = designation;
        }
    }
}
