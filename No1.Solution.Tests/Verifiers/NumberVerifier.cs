using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.Verifiers
{
    public class NumberVerifier
    {
        public static (bool, string) Verify(string password)
        {
            // check if password contains at least one digit character 
            if (!password.Any(c => char.IsNumber(c)))
                return (false, $"{password} hasn't digits");

            return (true, null);
        }
    }
}
