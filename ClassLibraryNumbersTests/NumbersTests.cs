using ClassLibraryNumbers;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using static ClassLibraryNumbers.Numbers;

namespace ClassLibraryNumbersTests
{
    [TestFixture()]
    public class NumbersTests
    {
        [TestCase(1, ExpectedResult = "3.1")]
        [TestCase(2, ExpectedResult = "3.14")]
        [TestCase(3, ExpectedResult = "3.141")]
        [TestCase(4, ExpectedResult = "3.1415")]
        [TestCase(5, ExpectedResult = "3.14159")]
        [TestCase(6, ExpectedResult = "3.141592")]
        public string FindPItoTheNthDigitTest(int n)
        {
            return FindPItoTheNthDigit(n);
        }

        [TestCase(1, ExpectedResult = "2.7")]
        [TestCase(2, ExpectedResult = "2.71")]
        [TestCase(3, ExpectedResult = "2.718")]
        [TestCase(4, ExpectedResult = "2.7182")]
        [TestCase(5, ExpectedResult = "2.71828")]
        [TestCase(6, ExpectedResult = "2.718281")]
        public string FindEToTheNthDigitTest(int n)
        {
            return FindEToTheNthDigit(n);
        }

        [TestCase(1, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        [TestCase(4, ExpectedResult = 3)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(13, ExpectedResult = 233)]
        public long FibonacciSequenceTest(int n)
        {
            return FibonacciSequence(n);
        }

        [TestCase(41, ExpectedResult = new long[] { 1, 41 })]
        [TestCase(4, ExpectedResult = new long[] { 1, 2, 2 })]
        [TestCase(2108, ExpectedResult = new long[] { 1, 2, 2, 17, 31 })]
        [TestCase(6207, ExpectedResult = new long[] { 1, 3, 2069 })]
        [TestCase(6144, ExpectedResult = new long[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 })]
        public long[] PrimeFactorizationTest(long n)
        {
            return PrimeFactorization(n).ToArray();
        }

        [TestCase(1, ExpectedResult = 2)]
        [TestCase(2, ExpectedResult = 3)]
        [TestCase(3, ExpectedResult = 5)]
        [TestCase(4, ExpectedResult = 7)]
        [TestCase(5, ExpectedResult = 11)]
        [TestCase(6, ExpectedResult = 13)]
        public long NextPrimeNumberTest(int n)
        {
            return NextPrimeNumber(n);
        }

        [TestCase(1.1, 1, 1, ExpectedResult = 1.1)]
        [TestCase(2, 2, 1, ExpectedResult = 4)]
        [TestCase(2, 1, 2, ExpectedResult = 4)]
        [TestCase(100, 100, 1.1, ExpectedResult = 10000*1.1)]
        [TestCase(400, 25, 200, ExpectedResult = 400*25*200)]
        public decimal FindCostOfTileToCoverWxHFloorTest(decimal w, decimal h, decimal cost)
        {
            return FindCostOfTileToCoverWxHFloor(w, h, cost);
        }

        [TestCase(1000, 12, 12, ExpectedResult = 13.13)]
        [TestCase(1000, 15, 12, ExpectedResult = 15.01)]
        [TestCase(1000, 20, 12, ExpectedResult = 18.37)]
        [TestCase(1000, 25, 12, ExpectedResult = 21.96)]
        [TestCase(1000, 50, 12, ExpectedResult = 41.78)]
        public double MortgageCalculatorTest(double loan, double interestRate, double term)
        {
            return MortgageCalculator(loan, interestRate, term);
        }

        [Test()]
        public void ChangeReturnProgramTest()
        {
            Assert.Fail();
        }

        [TestCase(10000, "", true)]
        //[TestCase(1000, 15, 12, ExpectedResult = 15.01)]
        //[TestCase(1000, 20, 12, ExpectedResult = 18.37)]
        //[TestCase(1000, 25, 12, ExpectedResult = 21.96)]
        //[TestCase(1000, 50, 12, ExpectedResult = 41.78)]
        public void BinaryToDecimalAndBackConverterTest(decimal numbDecimal, string numbBinary, bool direction)
        {
            BinaryToDecimalAndBackConverter(ref numbDecimal, ref numbBinary,direction);
        }

        [Test()]
        public void CalculatorTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void UnitConverterTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void AlarmClockTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void DistanceBetweenTwoCitiesTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CreditCardValidatorTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void TaxCalculatorTest()
        {
            Assert.Fail();
        }
    }
}