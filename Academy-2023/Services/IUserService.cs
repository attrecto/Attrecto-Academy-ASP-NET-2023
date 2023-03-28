using Academy_2023.Data;
using Academy_2023.Dto;

namespace Academy_2023.Services
{
    public interface IUserService
    {
        void Create(CreateUserDto userDto);
        bool Delete(int id);
        IEnumerable<UserListDto> GetAll();
        UserListDto? GetById(int id);
        User? Update(int id, CreateUserDto userDto);
        Task<User?> GetByEmailAsync(string email);
    }
}