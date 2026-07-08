using NUnit.Framework;
using UNIT_TESTING_R.ARITHMATIC;

namespace Testing
{
    [TestFixture]
    internal class OperationTest
    {
        Operation opr;
        [SetUp]
        public void SetupObject()
        {
            opr = new Operation();
        }

        [TestCase(10, 20, 30), Category("Basic")]
        [TestCase(7,8,15)]
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        public void AddTest(int a, int b, int expect)
        {
            var result = opr.Add(a, b);
            Assert.That(result, Is.EqualTo(expect));
        }

        [TestCase(20, 10, 10)]
        [TestCase(25, 15, 10)]
        public void SubTest(int a, int b, int expect)
        {
            var result = opr.Sub(a, b);
            Assert.That(result, Is.EqualTo(expect));
        }

        [TestCase(20, 10, 200)]
        public void MulTest(int a, int b, int expect)
        {
            var result = opr.Mul(a, b);
            Assert.That(result, Is.EqualTo(expect));
        }

    }
}
