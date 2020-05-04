using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConv1
{
    //Static Classes: A static class is a class that cannot be instantiated.
    public static class Conversions
    {
        // Convert argument from pounds to kilograms
        public static double PoundsToKilos(double pounds)
        {
            double kilos = pounds * 0.4536;
            return kilos;
        }

        //Convert argument from kilograms to pounds
        public static double KilosToPounds(double kilos)
        {
            double pounds = kilos * 2.205;
            return pounds;
        }
    }
}
