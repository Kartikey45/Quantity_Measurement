using NUnit.Framework;
using Quantity_measurement_problem;

namespace Quantity_measurement_problem_Test
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
    }
}