namespace Sample.BitTodo.Shared.Services.Contracts;

public interface IAuthTokenProvider
{
    Task<string?> GetAcccessToken();
}
