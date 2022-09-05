using Sample.BitTodo.Api.Models.Account;
using Sample.BitTodo.Shared.Dtos.Account;

namespace Sample.BitTodo.Api.Mappers;

public class AccountMapperConfiguration : Profile
{
    public AccountMapperConfiguration()
    {
        CreateMap<Role, RoleDto>().ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, EditUserDto>().ReverseMap();
        CreateMap<User, SignUpRequestDto>()
            .ReverseMap();
    }
}
