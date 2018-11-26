using NUnit.Framework;

using No1.Solution.Repository;
using No1.Solution.Tests.Verifiers;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {

        [TestCase("1237128736")]
        [TestCase("askdjhaskjdh")]
        public void UseSqlRepository_AddValidPassword_RepositoryContainsPassword(string password)
        {
            IRepository repository = new SqlRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            checkerService.Verify += LenghtVerifier.Verify;
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsTrue(repository.Contains(password));
        }

        [TestCase("1237128736")]
        [TestCase("askdjh123askjdh")]
        public void UseFileRepository_AddValidPassword_RepositoryContainsPassword(string password)
        {
            IRepository repository = new FileRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            checkerService.Verify += NumberVerifier.Verify;
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsTrue(repository.Contains(password));
        }

        [TestCase("123")]
        [TestCase("askdj")]
        public void UseSqlRepository_AddInvalidPassword_RepositoryDoesNotContainsPassword(string password)
        {
            IRepository repository = new SqlRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            checkerService.Verify += LenghtVerifier.Verify;
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsFalse(repository.Contains(password));
        }

        [TestCase("askdj")]
        [TestCase("askdjhaskjdh")]
        public void UseFileRepository_AddInvalidPassword_RepositoryDoesNotContainsPassword(string password)
        {
            IRepository repository = new SqlRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            checkerService.Verify += NumberVerifier.Verify;
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsFalse(repository.Contains(password));
        }
    }
}
