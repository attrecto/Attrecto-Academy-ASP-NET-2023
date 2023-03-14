using Academy_2023.Data;
using Academy_2023.Dto;

namespace Academy_2023.Services
{
    public interface IUserService
    {
        void Create(UserDto userDto);
        bool Delete(int id);
        IEnumerable<UserDto> GetAll();
        UserDto? GetById(int id);
        User? Update(int id, UserDto userDto);
    }
}