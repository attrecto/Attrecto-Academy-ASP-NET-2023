using Academy_2023.Data;

namespace Academy_2023.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

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

        public User? Update(int id, User data)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                user.Email = data.Email;
                user.Password = data.Password;
                user.FirstName = data.FirstName;
                user.LastName = data.LastName;

                _context.SaveChanges();
            }

            return user;
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
    }
}
