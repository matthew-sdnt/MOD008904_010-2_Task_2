using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Classes
{
    internal class Kelvin : Measurement
    {
        //Constructor (inherits logic from base class).
        public Kelvin(double p_temperature) : base(p_temperature)
        {
            this.unit = "Kelvin";
        }

        //Output as celsius.
        public override double as_celsius()
        {
            return temperature - 273.15;
        }
        //Output as kelvin (self).
        public override double as_kelvin()
        {
            return temperature;
        }
        //Output as fahrenheit.
        public override double as_fahrenheit()
        {
            return temperature * 1.8 - 459.67;
        }
    }
}
