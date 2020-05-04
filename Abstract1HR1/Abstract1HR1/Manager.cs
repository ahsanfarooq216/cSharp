using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract1HR1
{
    class Manager : Employee //Manager inherits employee
    {
        private string department;

        public string Department { get => department; set => department = value; } // Shortcut: (ctrl+R) + (ctrl+E)

        public override void Login()
        {
            base.Login();
            Console.WriteLine("Manager Dogin'");
        }
        public override void Hire()
        {
            Console.WriteLine("Hire someone");
        }
    }
}
