using Academy_2023.Data;
using Microsoft.EntityFrameworkCore;

namespace Academy_2023.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Create(User data)
        {
            _context.Users.Add(data);

            _context.SaveChanges();
        }

        public void Update()
        {
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                _context.Users.Remove(user);

                _context.SaveChanges();

                return true;
            }

            return false;
        }

        public Task<User?> GetByEmailAsync(string email)
        {
            return _context.Users.SingleOrDefaultAsync(u => u.Email == email);
        }
    }
}
