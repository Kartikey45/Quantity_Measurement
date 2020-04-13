using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class InchToCentimeter
    {
        public double centimeterCompare(string input)
        {
            double centimeter = 2.5;
            double inch = 2;

            if(input!=null)
            {
                if(double.TryParse(input, out inch))
                {
                    inch = inch * centimeter;
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INPUT_NULL, "Null");
            }
            return inch;
        }
    }
}
