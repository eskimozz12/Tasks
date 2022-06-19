using NUnit.Framework;
using Test1Library;

namespace Test_Task1
{
    public class PrimeCheckerTests
    {
        
        PrimeChecker? checker;
        [SetUp]
        public void Setup()
        {

            checker = new PrimeChecker();
        }
        [TearDown]
        public void TearDown()
        {
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void TestOther(int value)
        {
            Assert.AreEqual(checker?.IsPrime(value), PrimeChecker.NumberType.Other);
        }
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        public void TestPrime(int value)
        {
            Assert.AreEqual(checker?.IsPrime(value), PrimeChecker.NumberType.Prime);
        }
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(25)]
        public void TestComposite(int value)
        {
            Assert.AreEqual(checker?.IsPrime(value), PrimeChecker.NumberType.Composite);

        }
    }
}