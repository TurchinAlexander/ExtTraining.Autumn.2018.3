using System;
using System.Linq;

using No1.Solution.Repository;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        public event Func<string, (bool, string)> Verify;
        private IRepository repository;

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public (bool, string) VerifyPassword(string password)
        {
            (bool, string) result = this.Verify(password);
            if (!result.Item1)
                return result;

            repository.Add(password);

            return (true, "Password is Ok. User was created");
        }
    }
}
