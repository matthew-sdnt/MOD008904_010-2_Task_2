using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Classes
{
    internal abstract class Measurement
    {
        //Base class.
        //Fields
        protected double temperature; //To store the temperature.

        protected Measurement(double p_temperature)
        {
            this.temperature = p_temperature;
        }

        //Methods (to be overridden in derivative classes, thus the abstract keyword).
        public abstract double as_celsius();
        public abstract double as_kelvin();
        public abstract double as_fahrenheit();
    }
}