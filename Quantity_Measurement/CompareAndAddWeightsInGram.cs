using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class CompareAndAddWeightsInGram
    {
        public double gramToKg(string input)
        {
            double gram = 1;
            double kilogram = 1000;

            if (input != null)
            {
                if (double.TryParse(input, out gram))
                {
                    gram = gram / kilogram;
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
            return gram;
        }

        public double TonneTokg(string input)
        {
            double tonne = 1;
            double kilogram = 1000;

            if (input != null)
            {
                if (double.TryParse(input, out tonne))
                {
                    tonne = tonne * kilogram;
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
            return tonne;
        }
    }
}
