using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class FeetComparision
    {
        // Calulate and compare units 
        public double feetcompare(string input)
        {
            double feet = 1;
            double inch = 12;

            if (input != null)
            {

                if (double.TryParse(input, out feet))
                {
                    if(feet == inch)
                        feet = feet * inch;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Type not match");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INPUT_NULL, "Null");
            }
            return feet;
        }
    }
}
