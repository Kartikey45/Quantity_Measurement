using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class AddTwoLengthsInInches
    {
        public double InchPlusInch(double inch1 , double inch2)
        {
            double AdditionOfInches = inch1 + inch2;
            return AdditionOfInches;
        }

        public double FeetPlusInch(double inch)
        {
            FeetToInchConvert comparision = new FeetToInchConvert();
            double AdditionOnFeetAndInch = inch + comparision.FeetToInch("1");
            return AdditionOnFeetAndInch;
        }

        public double FeetPlusFeet()
        {
            FeetToInchConvert comparision = new FeetToInchConvert();
            double AdditionOfFeetAndFeet = comparision.FeetToInch("1") + comparision.FeetToInch("1");
            return AdditionOfFeetAndFeet;
        }

        public double CentimeterPlusInch(double inch)
        {
            CentimeterToInchConvert comparision = new CentimeterToInchConvert();
            double AdditionOfInchAndCentimeter = comparision.centimeterToInch("2.5") + inch;
            return AdditionOfInchAndCentimeter;
        }
    }
}
