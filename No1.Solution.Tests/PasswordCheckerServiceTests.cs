using NUnit.Framework;

using No1.Solution.Repository;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        private static object[] ValidPasswords = new object[]
        {
            "123herHell0",
            "Char123heh"
        };

        private static object[] InvalidPasswords = new object[]
        {
            "123",
            "HELLO",
            "Bigstringwithmanychars"
        };

        [TestCaseSource("ValidPasswords")]
        public void UseSqlRepository_AddValidPassword_RepositoryContainsPassword(string password)
        {
            IRepository repository = new SqlRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsTrue(repository.Contains(password));
        }

        [TestCaseSource("ValidPasswords")]
        public void UseFileRepository_AddValidPassword_RepositoryContainsPassword(string password)
        {
            IRepository repository = new FileRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsTrue(repository.Contains(password));
        }

        [TestCaseSource("InvalidPasswords")]
        public void UseSqlRepository_AddInvalidPassword_RepositoryDoesNotContainsPassword(string password)
        {
            IRepository repository = new SqlRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsFalse(repository.Contains(password));
        }

        [TestCaseSource("InvalidPasswords")]
        public void UseFileRepository_AddInvalidPassword_RepositoryDoesNotContainsPassword(string password)
        {
            IRepository repository = new SqlRepository();
            PasswordCheckerService checkerService = new PasswordCheckerService(repository);
            (bool, string) actual = checkerService.VerifyPassword(password);

            Assert.IsFalse(repository.Contains(password));
        }
    }
}
