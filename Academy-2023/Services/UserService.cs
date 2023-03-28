using Academy_2023.Data;
using Academy_2023.Dto;
using Academy_2023.Repositories;

namespace Academy_2023.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserListDto> GetAll()
        {
            var users = _userRepository.GetAll();

            return users.Select(MapToListDto);
        }

        public UserListDto? GetById(int id)
        {
            var user = _userRepository.GetById(id);

            return user == null ? null : MapToListDto(user);
        }

        public void Create(CreateUserDto userDto)
        {
            var newUser = MapToEntity(userDto);
            newUser.CreatedAt = DateTime.Now;
            newUser.Role = Role.User.ToString();

            _userRepository.Create(newUser);
        }

        public User? Update(int id, CreateUserDto userDto)
        {
            var user = _userRepository.GetById(id);

            if (user != null)
            {
                user.Email = userDto.Name;
                user.Password = userDto.Password;
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.ImageUrl = userDto.Image;

                _userRepository.Update();
            }

            return user;
        }

        public bool Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public Task<User?> GetByEmailAsync(string email)
        {
            return _userRepository.GetByEmailAsync(email);
        }

        private UserListDto MapToListDto(User user) => new UserListDto { Id = user.Id, Name = user.Email, Image = user.ImageUrl };

        private User MapToEntity(CreateUserDto userDto) => new User { Email = userDto.Name, Password = userDto.Password, FirstName = userDto.FirstName, LastName = userDto.LastName, ImageUrl = userDto.Image };
    }
}
