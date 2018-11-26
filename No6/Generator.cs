using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class Generator
    {
        public static IEnumerable<T> Execute<T>(int count, Func<int, T> ReccurentFormula)
        {
            if (ReccurentFormula == null)
            {
                throw new ArgumentNullException(nameof(ReccurentFormula));
            }

            if (count < 1)
            {
                throw new ArgumentException($"{nameof(count)} can't be negative or zero");
            }

            return GeneratorLogic();

            IEnumerable<T> GeneratorLogic()
            {
                for (int i = 1; i <= count; i++)
                {
                    yield return ReccurentFormula(i);
                }
            }
        }
    }
}
