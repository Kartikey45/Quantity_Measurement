using NUnit.Framework;
using Quantity_measurement_problem;

namespace Quantity_measurement_problem_Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            FeetComparision compare = new FeetComparision();
            int result = compare.feetcompare("0");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2()
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
    }
}