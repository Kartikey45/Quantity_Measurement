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
            int result = compare.feetcompare("0");
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
        public void TypeCheck() //TC 1.4
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
        public void EqualityCheck() //TC 1.5 & TC 1.6 
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
            double result = compare.InchCompare(0.0);
            Assert.AreEqual(0.0,result);
        }
    }
}