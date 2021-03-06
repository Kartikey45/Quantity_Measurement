﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class InchComparision
    {
        public double InchCompare(string input)
        {
            double inch = 1;
            double feet = 12;

            if (input != null)
            {
                if (double.TryParse(input, out inch))
                {
                    inch = inch / feet;
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
            return inch;
        }
    }
}
