using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.Infrastructure;

namespace TodoApi.Services;

public class TodoService
{
    private readonly TodoRepository _todoRepository;
    public TodoService(TodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<TodoItemDTO> GetTodoItem(long id)
    {
        TodoItem item = await _todoRepository.GetTodoItem(id);
        var itemDto = ItemToDTO(item);
        return itemDto;


    }
    private static TodoItemDTO ItemToDTO(TodoItem todoItem) =>
        new TodoItemDTO
        {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete
        };
}
