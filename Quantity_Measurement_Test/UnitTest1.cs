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
    }
}