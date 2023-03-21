using Academy_2023.Data;

namespace Academy_2023.Repositories
{
    public interface IUserRepository
    {
        void Create(User data);
        bool Delete(int id);
        IEnumerable<User> GetAll();
        User? GetById(int id);
        void Update();
        Task<User?> GetByEmailAsync(string email);
    }
}