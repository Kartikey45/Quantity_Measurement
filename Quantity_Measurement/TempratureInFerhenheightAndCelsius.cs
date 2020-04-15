using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class TempratureInFehrenheitAndCelsius
    {
        public double Temprature(double fahrenheit)
        {
            double celsius  = (fahrenheit - 32) * 5/9;
            return celsius;
        }
    }
}
