using System.Collections.Generic;

namespace No1.Solution.Repository
{
    public class FileRepository : IRepository
    {
        List<string> passwordList = new List<string>();

        public void Add(string password)
        {
            if (passwordList.Contains(password))
                return;

            passwordList.Add(password);
        }

        public bool Contains(string password)
        {
            return passwordList.Contains(password);
        }

        public void Remove(string password)
        {
            passwordList.Remove(password);
        }
    }
}
