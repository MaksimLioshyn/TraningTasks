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
    }
}