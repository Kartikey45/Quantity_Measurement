using NUnit.Framework;
using Quantity_Measurement;

namespace Quantity_Measurement_Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            FeetComparision compare = new FeetComparision();
            int result = compare.feetcompare(0);
            Assert.AreEqual(0, result);
        }
    }
}