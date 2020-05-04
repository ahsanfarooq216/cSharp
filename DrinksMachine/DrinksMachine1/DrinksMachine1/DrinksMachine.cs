using System;
using System.Collections.Generic;
using System.Text;

namespace DrinksMachine1
{
    //Declaring a Class
    public partial class DrinksMachine
    {
        // Defining Class Members. Methods, fields, properties, and events go here.
        // The following statements define a property with a private field.
        private string _location;
        public String Location
        {
            get
            {
                return _location;
            }
            set
            {
                if (value != null)
                {
                    _location = value;
                }
            }
        }

        // The following statements define properties.
        private string _make;
        public string Make
        { 
            get { return _make; }
            set {_make = value; }
        }
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        //Constructors
        public DrinksMachine()
        {
        }
        public DrinksMachine(int age, string make)
        {
            this.Age = age;
        }
        public DrinksMachine(int age, string loc, string make, string model)
        {
            this.Age = age;
            this.Location = loc;
            this.Model = model;
            this.Make = make;
        }
        // The following statements define methods.
        public void MakeCappuccino()
        {
            //Method logic goes here
        }
        public void MakeEspresso()
        {
            //Method logic goes here
            Console.WriteLine("Espresso shots: 2");
        }
        // The following statement defines an event. The delegate definition is not shown.
        //public event OutOfBeansHandler OutOfBeans;
    }
}
