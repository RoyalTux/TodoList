using System.Collections.Generic;
using TodoList.Entities;

namespace TodoList.Services
{
    public class TodoItemService
    {
        static TodoItemService()
        {
            TodoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Choose technology and programming language",
                IsItemComplete = true,
                ItemDetails = "Find the documentation and all the necessary materials",
                ItemId = _lastId

            });

            TodoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Learn Asp.Net Core",
                IsItemComplete = false,
                ItemDetails = "Learn theory and practice new things",
                ItemId = _lastId

            });

            TodoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Raise the level of knowledge in English",
                IsItemComplete = false,
                ItemDetails = "Read English literature and communicate with native speakers",
                ItemId = _lastId

            });

            TodoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Prepare for an interview",
                IsItemComplete = false,
                ItemDetails = "Repeat all the material",
                ItemId = _lastId

            });
        }

        private static readonly SortedDictionary<long, TodoItem> TodoItems
            = new SortedDictionary<long, TodoItem>();

        private static long _lastId = 0;

        public IEnumerable<TodoItem> GetAll() => TodoItems.Values;

        public TodoItem GetOne(long id) => TodoItems[id];

        public void Add(TodoItem todoItem)
        {
            todoItem.ItemId = ++_lastId;
            TodoItems.Add(todoItem.ItemId, todoItem);
        }

        public void Remove(long id) => TodoItems.Remove(id);

        public void Complete(long id)
        {
            TodoItems[id].IsItemComplete = true;
        }
    }
}
