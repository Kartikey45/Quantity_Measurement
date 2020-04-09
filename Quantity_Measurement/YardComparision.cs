using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class YardComparision
    {
        public double yardCompare(string input)
        {
            double yard = 1;
            double feet = 3;

            if (input != null)
            {
                if (double.TryParse(input, out yard))
                {
                    yard = yard * feet;
                }
                else
                {
                    // Exception Throw For Type Not Match
                    throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Type Not Match");
                }
            }
            else
            {
                // Exception Throw If Value Is Null
                throw new CustomException(CustomException.ExceptionType.INPUT_NULL, "Null");
            }
            return yard;
        }
    }
}

