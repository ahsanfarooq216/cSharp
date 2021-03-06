﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars2
{
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        // Creates integer variable called "instances" and assigns value to 0
        public static int instances = 0;

        // Adding a Constructor 
        // This constructor instantiates a Car() object while only having the car's color and year information available

        public Car(string color, int year)
        {
            this.Color = color;
            Year = year; //works without "this" keyword. why?
            // Every time the constructor runs, increment "instances"
            instances++;
        }
                
        //Adding another Constructor
        // This constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int miles)
        {
            Year = year; //works without "this" keyword. why?
            this.Mileage = miles;
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        public Car()
        {
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        // Declare static member
        public static int CountCars()
        {
            return instances;
        }
    }
}
