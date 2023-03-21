using Academy_2023.Data;
using Academy_2023.Dto;

namespace Academy_2023.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
    }
}
