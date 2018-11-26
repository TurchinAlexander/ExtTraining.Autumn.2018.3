using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public static class Extension
    {
        public static double AverageMethod(this List<double> values, Func<List<double>, double> AverageMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (AverageMethod == null)
            {
                throw new ArgumentNullException(nameof(AverageMethod));
            }

            return AverageMethod(values);
        }
    }
}
