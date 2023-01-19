using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Infrastructure
{
	public class TodoRepository
	{
		private readonly TodoContext _context;


		public TodoRepository(TodoContext todoContext)
		{
			_context = todoContext;
		}

		public async Task<TodoItem> GetTodoItem(long id)
		{
			TodoItem todoItem = await _context.TodoItems.FindAsync(id);
			return todoItem;

		}
	}
}
