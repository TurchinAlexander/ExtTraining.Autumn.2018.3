using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.Verifiers
{
    public class LenghtVerifier
    {
        public static (bool, string) Verify(string password)
        {
            // check if length less than 7 chars for admins
            if (password.Length < 7)
                return (false, $"{password} length too small");

            return (true, null);
        }
    }
}
