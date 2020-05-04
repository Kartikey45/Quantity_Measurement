using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class TempratureInFehrenheitAndCelsius
    {
        public double FehrenheightToCelsiusConversion(double fahrenheit)
        {
            double celsius  = (fahrenheit - 32) * 5/9;
            return celsius;
        }

        public double CelsiusToFehrenheightConversion(double celsius)
        {
            double Fehrenheight = (celsius * 9 / 5) + 32;
            return Fehrenheight;
        }
    }
}
