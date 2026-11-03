using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Classes
{
    internal class Celsius : Measurement
    {
        //Constructor (inherits logic from base class).
        public Celsius(double p_temperature) : base(p_temperature)
        {
            this.unit = "Celsius";
        }

        //Output as celsius (self).
        public override double as_celsius()
        {
            return temperature;
        }
        //Output as kelvin.
        public override double as_kelvin()
        {
            return temperature + 273.15;
        }
        //Output as fahrenheit.
        public override double as_fahrenheit()
        {
            return temperature * 1.8 + 32;
        }
    }
}
