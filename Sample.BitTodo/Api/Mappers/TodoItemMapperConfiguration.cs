using Sample.BitTodo.Api.Models.TodoItem;
using Sample.BitTodo.Shared.Dtos.TodoItem;

namespace Sample.BitTodo.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
