using System;
using System.Linq;

using No1.Solution.Repository;

/*
 * Чтобы избавиться от зависимости от конкретного объекта, 
 * мы реализуем интерфейс IRepository, который будет являться контрактом
 * между нашим сервисом и репозиторием.
 * В данном примере мы можем без особого труда поменять SqlRepository на FIleRepository.
 */

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
