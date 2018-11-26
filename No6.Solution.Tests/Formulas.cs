using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6.Solution.Tests
{
    public static class Formula
    {
        public static int Fibonacci(int number)
        {
            if (number <= 2)
                return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        public static int WithMultiply(int number)
        {
            if (number <= 1)
                return 1;

            if (number == 2)
                return 2;
             
            return 6 * WithMultiply(number - 1) - 8 * WithMultiply(number - 2);
        }

        public static double WithDivide(int number)
        {
            if (number <= 1)
                return 1;

            if (number == 2)
                return 2;

            return WithDivide(number - 1) + WithDivide(number - 2) / WithDivide(number - 1);
        }
    }
}
