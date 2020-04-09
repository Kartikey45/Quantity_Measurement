using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class InchComparision
    {
        public double InchCompare(double inch)
        {
            double feet = 0.083;
            inch = inch * feet;
            return inch;
        }
    }
}
