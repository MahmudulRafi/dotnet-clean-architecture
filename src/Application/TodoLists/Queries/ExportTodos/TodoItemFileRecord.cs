using EMS.Application.Common.Mappings;
using EMS.Domain.Entities;

namespace EMS.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
