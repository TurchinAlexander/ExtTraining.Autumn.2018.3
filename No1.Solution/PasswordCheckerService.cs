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
        private IRepository repository;

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return (false, $"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return (false, $"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return (false, $"{password} length too long");

            // check if password contains at least one alphabetical character 
            if (!password.Any(c => char.IsLetter(c)))
                return (false, $"{password} hasn't alphanumerical chars");

            // check if password contains at least one digit character 
            if (!password.Any(c => char.IsNumber(c)))
                return (false, $"{password} hasn't digits");

            repository.Add(password);

            return (true, "Password is Ok. User was created");
        }
    }
}
