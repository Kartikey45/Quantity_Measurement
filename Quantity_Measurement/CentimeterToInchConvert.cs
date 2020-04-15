using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class CentimeterToInchConvert
    {
        public double centimeterToInch(string input)
        {
            double centimeter = 2.5;
            //double inch = 1;

            if (input != null)
            {

                if (double.TryParse(input, out double centimetre))
                {
                    centimeter = centimetre / centimeter;
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
            return centimeter;
        }
    }
}
