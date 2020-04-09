using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_measurement_problem
{
    public class FeetComparision
    {
        // Calulate and compare units 
        public int feetcompare(string input)
        {
            int feet = 0;
            int inch = 12;
            //feet = feet * inch;

            if (input != null)
            {

                if (int.TryParse(input, out feet))
                {

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
