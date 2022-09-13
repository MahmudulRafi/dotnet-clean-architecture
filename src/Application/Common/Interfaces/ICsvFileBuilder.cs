using EMS.Application.TodoLists.Queries.ExportTodos;

namespace EMS.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
