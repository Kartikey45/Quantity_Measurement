using NUnit.Framework;
using Quantity_Measurement;

namespace Quantity_Measurement_Test
{
    public class Tests
    {
        [Test]
        public void Test1()  //TC 1.1
        {
            FeetComparision compare = new FeetComparision();
            double result = compare.feetcompare("0");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2()  //TC 1.2
        {
            FeetComparision compare = new FeetComparision();
            try
            {
                compare.feetcompare(null);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INPUT_NULL, e.type);
            }
        }

        [Test]
        public void Test3() //TC 1.3
        {
            FeetComparision compare = new FeetComparision();
            compare.feetcompare("0");
            FeetComparision compar2 = new FeetComparision();
            compar2.feetcompare("0");
            compare = compar2;
            bool areEqual = ReferenceEquals(compare, compar2);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void Test4() //TC 1.4
        {
            FeetComparision compare = new FeetComparision();
            compare.feetcompare("0");
            FeetComparision compar2 = new FeetComparision();
            compar2.feetcompare("0");
            bool areEqual = ReferenceEquals(compare, compar2);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void TypeCheck() //TC 1.5
        {
            FeetComparision compare = new FeetComparision();
            try
            {
                compare.feetcompare("");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.TYPE_NOT_MATCH, e.type);
            }
        }

        [Test]
        public void EqualityCheck() //TC 1.6 
        {
            FeetComparision compare = new FeetComparision();
            compare.feetcompare("0");
            FeetComparision compare2 = new FeetComparision();
            compare2.feetcompare("0");
            bool IsEqual = ReferenceEquals(compare.GetType(), compare2.GetType());
            Assert.IsTrue(IsEqual);
        }

        [Test]
        public void zeroInchAndZeroInchReturnEqual() //TC 1.7
        {
            InchComparision compare = new InchComparision();
            double result = compare.InchCompare("0.0");
            Assert.AreEqual(result, 0.0);
        }

        [Test]
        public void NullCheckforInchComparision() //TC 1.8
        {
            InchComparision compare = new InchComparision();
            try 
            {
                compare.InchCompare(null);
            }
            catch(CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INPUT_NULL, e.type);
            }
        }

        [Test]
        public void RefCheckforInchComparision() // TC 1.9
        {
            InchComparision compare = new InchComparision();
            compare.InchCompare("0.0");
            InchComparision compare2 = new InchComparision();
            compare2.InchCompare("0.0");
            compare = compare2;
            bool AreEqual = ReferenceEquals(compare,compare2);
            Assert.IsTrue(AreEqual);
        }

        [Test]
        public void RefCheckforInchComparisionReturnFalse() // TC 1.10 
        {
            InchComparision compare = new InchComparision();
            compare.InchCompare("0.0");
            InchComparision compare2 = new InchComparision();
            compare2.InchCompare("0.0");
            bool AreEqual = ReferenceEquals(compare,compare2);
            Assert.IsFalse(AreEqual);
        }

        [Test]
        public void TypeCheckforInchComparision() // TC 1.11
        {
            InchComparision compare = new InchComparision();
            try
            {
                compare.InchCompare("");
            }
            catch(CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.TYPE_NOT_MATCH, e.type);
            }
        }

        [Test]
        public void EqualityCheckforInchComparision() //Tc 1.12
        {
            InchComparision compare = new InchComparision();
            InchComparision compare2 = new InchComparision();
            bool isEqual = ReferenceEquals(compare.GetType(),compare2.GetType());
            Assert.IsTrue(isEqual);
        }

        [Test]
        public void zeroFeetAndZeroInchReturnsEqual() //TC 1.13
        {
            FeetComparision compare = new FeetComparision();
            double result1 = compare.feetcompare("0");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("0.0");
            Assert.AreEqual(result1,result2);
        }

        [Test]
        public void oneFeetNotEqualToOneInch() // TC 1.14
        {
            FeetComparision compare = new FeetComparision();
            double result1 = compare.feetcompare("1");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("1.0");
            Assert.AreNotEqual(result1, result2);
        }

        [Test]
        public void oneInchNotEqualToOneFeet() // TC 1.15
        {
            FeetComparision compare = new FeetComparision();
            double result1 = compare.feetcompare("1");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("1.0");
            Assert.AreNotEqual(result1, result2);
        }

        [Test]
        public void oneFeetEqualTo12Inch() //TC 1.16
        {
            FeetComparision compare = new FeetComparision();
            double result1 = compare.feetcompare("1");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("12");
            Assert.AreEqual(result1, result2);
        }

        [Test]
        public void twelveInchEqualToOneInch()
        {
            FeetComparision compare = new FeetComparision();
            double result1 = compare.feetcompare("1");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("12");
            Assert.AreEqual(result2, result1);
        }

        [Test]
        public void ThreeFeetEqualTo1Yard()
        {
            YardComparision compare = new YardComparision();
            double result = compare.yardCompare("1");
            FeetComparision compare2 = new FeetComparision();
            double result2 = compare2.feetcompare("3");
            Assert.AreEqual(result,result2);
        }

        [Test]
        public void OneFeetNotEqualTo1Yard()
        {
            YardComparision compare = new YardComparision();
            double result = compare.yardCompare("1");
            FeetComparision compare2 = new FeetComparision();
            double result2 = compare2.feetcompare("1");
            Assert.AreNotEqual(result, result2);
        }

        [Test]
        public void OneInchNotEqualTo1Yard()
        {
            YardComparision compare = new YardComparision();
            double result = compare.yardCompare("1");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("1");
            Assert.AreNotEqual(result, result2);
        }

        [Test]
        public void OneYadEqualTo36Inch()
        {
            YardComparision compare = new YardComparision();
            double result = compare.yardCompare("1");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("36");
            Assert.AreEqual(result, result2);
        }

        [Test]
        public void ThirtySixInchEqualTo1Yard()
        {
            YardComparision compare = new YardComparision();
            double result = compare.yardCompare("1");
            InchComparision compare2 = new InchComparision();
            double result2 = compare2.InchCompare("36");
            Assert.AreEqual(result2, result);
        }

        [Test]
        public void OneYardEqualTo3Feet()
        {
            YardComparision compare = new YardComparision();
            double result = compare.yardCompare("1");
            FeetComparision compare2 = new FeetComparision();
            double result2 = compare2.feetcompare("3");
            Assert.AreEqual(result, result2);
        }

        [Test]
        public void InchEqualToCentimeter() //UC 3 Compare lengths Inch to Centimeter
        {
            InchToCentimeter inchToCentimeter = new InchToCentimeter();
            double result = inchToCentimeter.centimeterCompare("2");
            Assert.AreEqual(result,5);
        }

        [Test]
        public void InchAndInchAddition() //UC 4 Add two length in inches
        {
            AddTwoLengthsInInches addTwoLengths = new AddTwoLengthsInInches();
            double result = addTwoLengths.InchPlusInch(2,2);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void InchAndFeetAddition() //UC 4 Add two length in inches
        {
            AddTwoLengthsInInches addTwoLengths = new AddTwoLengthsInInches();
            double result = addTwoLengths.FeetPlusInch(2);
            Assert.AreEqual(14, result);
        }

        [Test]
        public void FeetAndFeetAddition() //UC 4 Add two length in inches
        {
            AddTwoLengthsInInches addTwoLengths = new AddTwoLengthsInInches();
            double result = addTwoLengths.FeetPlusFeet();
            Assert.AreEqual(24, result);
        }

        [Test]
        public void InchAndCentimeterAddition() //UC 4 Add two length in inches
        {
            AddTwoLengthsInInches addTwoLengths = new AddTwoLengthsInInches();
            double result = addTwoLengths.CentimeterPlusInch(2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void VolumeCompare() //UC 5 Compare volume in litre and gallon
        {
            VolumeConvert convert = new VolumeConvert();
            double result = convert.gallonToLitre(1);
            Assert.AreEqual(3.78, result);
        }

        [Test]
        public void gallonPlusLitre() //UC 6 Add two Volumes
        {
            VolumeConvert convert = new VolumeConvert();
            double result = convert.AddGallonInLitre(3.78);
            Assert.AreEqual(7.56, result);
        }

        [Test]
        public void LitrePlusMililitre() //UC 6 Add two volumes
        {
            VolumeConvert convert = new VolumeConvert();
            double result = convert.AddMililitreInLitre(1);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AddWeightInGram() // UC 7 Add weights in grams
        {
            CompareAndAddWeightsInGram WeightsInGram = new CompareAndAddWeightsInGram();
            double result = WeightsInGram.gramToKg("1000") + WeightsInGram.TonneTokg("1");
            Assert.AreEqual(1001, result);
        }

        [Test]
        public void FehrenheightToCelsius() // UC 8 Fehrenheit to celsius convert
        {
            TempratureInFehrenheitAndCelsius fehrenheitToCelsius = new TempratureInFehrenheitAndCelsius();
            double result = fehrenheitToCelsius.FehrenheightToCelsiusConversion(212);
            Assert.AreEqual(result,100);
        }

        [Test]
        public void CelsiusToFehrenheight() // UC 8 Celsius to fehrenheit convert
        {
            TempratureInFehrenheitAndCelsius celsiusToFehrenheight = new TempratureInFehrenheitAndCelsius();
            double result = celsiusToFehrenheight.CelsiusToFehrenheightConversion(100);
            Assert.AreEqual(result, 212);
        }
    }
}