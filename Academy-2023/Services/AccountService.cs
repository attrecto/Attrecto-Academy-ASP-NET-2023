using Academy_2023.Data;
using Academy_2023.Dto;

namespace Academy_2023.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserService _userService;

        public AccountService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User?> LoginAsync(LoginDto loginDto)
        {
            var user = await _userService.GetByEmailAsync(loginDto.Email);

            if (user == null || user.Password != loginDto.Password)
            {
                return null;
            }

            return user;
        }
    }
}
