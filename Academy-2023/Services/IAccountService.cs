using Academy_2023.Data;
using Academy_2023.Dto;

namespace Academy_2023.Services
{
    public interface IAccountService
    {
        Task<User?> LoginAsync(LoginDto loginDto);
    }
}
