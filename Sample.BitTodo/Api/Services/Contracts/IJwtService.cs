using Sample.BitTodo.Api.Models.Account;
using Sample.BitTodo.Shared.Dtos.Account;

namespace Sample.BitTodo.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
