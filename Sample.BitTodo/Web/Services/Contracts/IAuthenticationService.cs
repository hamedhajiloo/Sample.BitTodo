using Sample.BitTodo.Shared.Dtos.Account;

namespace Sample.BitTodo.App.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
