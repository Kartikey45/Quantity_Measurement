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
                    //return feet;

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
