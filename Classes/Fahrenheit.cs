using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Classes
{
    internal class Fahrenheit : Measurement
    {
        //Constructor (inherits logic from base class).
        public Fahrenheit(double p_temperature) : base(p_temperature)
        {
            this.unit = "Fahrenheit";
        }

        //Output as celsius.
        public override double as_celsius()
        {
            return (temperature - 32) / 1.8;
        }
        //Output as kelvin.
        public override double as_kelvin()
        {
            return (temperature + 459.67) / 1.8 ;
        }
        //Output as fahrenheit (self).
        public override double as_fahrenheit()
        {
            return temperature;
        }
    }
}
