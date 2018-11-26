using System.Collections.Generic;
using NUnit.Framework;

using No3.Solution.Tests.AverageMethods;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMeanExtension()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            double actual = values.AverageMethod(MeanAverage.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMeanMethod()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            double actual = Method.Average(values, MeanAverage.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianExtension()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = values.AverageMethod(MedianAverage.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianMethod()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = Method.Average(values, MedianAverage.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}