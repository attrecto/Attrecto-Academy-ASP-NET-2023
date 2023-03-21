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

        public IEnumerable<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();

            return users.Select(MapToDto);
        }

        public UserDto? GetById(int id)
        {
            var user = _userRepository.GetById(id);

            return user == null ? null : MapToDto(user);
        }

        public void Create(UserDto userDto)
        {
            _userRepository.Create(MapToEntity(userDto));
        }

        public User? Update(int id, UserDto userDto)
        {
            var user = _userRepository.GetById(id);

            if (user != null)
            {
                user.Email = userDto.Email;
                user.Password = userDto.Password;
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;

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

        private UserDto MapToDto(User user) => new UserDto { Id = user.Id, Email = user.Email, Password = user.Password, FirstName = user.FirstName, LastName = user.LastName };

        private User MapToEntity(UserDto userDto) => new User { Id = userDto.Id, Email = userDto.Email, Password = userDto.Password, FirstName = userDto.FirstName, LastName = userDto.LastName };
    }
}
