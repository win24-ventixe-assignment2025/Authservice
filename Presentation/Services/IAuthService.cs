using Presentation.Entities;
using Presentation.Models;

namespace Presentation.Services;

public interface IAuthService
{
    Task<User?> RegisterAsync(UserDto request);
    Task <TokenResponseDto?> LoginAsync(UserDto request);
    Task<TokenResponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
}
