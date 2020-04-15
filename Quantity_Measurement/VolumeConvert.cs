using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    public class VolumeConvert
    {
        public double gallonToLitre(double gallon)
        {
            double litre = 3.78;
            gallon = gallon * litre;
            return gallon;
        }

        public double mililitreToLitre(string input)
        {
            double miliLitre = 1;
            double Litre = 1000;
            /*double inch = 1;
            double feet = 12;*/

            if (input != null)
            {
                if (double.TryParse(input, out miliLitre))
                {
                    miliLitre = miliLitre / Litre;
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
            return miliLitre;
        }

        public double AddGallonInLitre(double Litre)
        {
            VolumeConvert convert = new VolumeConvert();
            Litre = convert.gallonToLitre(1) + Litre;
            return Litre;
        }

        public double AddMililitreInLitre(double Litre)
        {
            VolumeConvert convert = new VolumeConvert();
            Litre = Litre + convert.mililitreToLitre("1000");
            return Litre;
        }
    }
}
