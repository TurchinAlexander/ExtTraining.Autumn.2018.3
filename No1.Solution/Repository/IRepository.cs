namespace No1.Solution.Repository
{
    public interface IRepository
    {
        void Add(string password);
        void Remove(string password);
        bool Contains(string password);
    }
}
