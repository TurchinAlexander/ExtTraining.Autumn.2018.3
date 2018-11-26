
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            IEnumerable<int> actual = Generator.Execute(expected.Length, Formula.Fibonacci);

            Assert.IsTrue(CheckTwoArrays(expected, actual));
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            IEnumerable<int> actual = Generator.Execute(expected.Length, Formula.WithMultiply);

            Assert.IsTrue(CheckTwoArrays(expected, actual));
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            IEnumerable<double> actual = Generator.Execute(expected.Length, Formula.WithDivide);

            Assert.IsTrue(CheckTwoArrays(expected, actual, 0.001));
        }

        private bool CheckTwoArrays(int[] expected, IEnumerable<int> actual)
        {
            int i = 0;
            foreach (var element in actual)
            {
                if (element != expected[i++])
                    return false;
            }

            return true;
        }

        private bool CheckTwoArrays(double[] expected, IEnumerable<double> actual, double epsilon)
        {
            int i = 0;
            foreach (var element in actual)
            {
                if (Math.Abs(element - expected[i++]) > epsilon)
                    return false;
            }

            return true;
        }
    }
}
