using System.Collections.Generic;

namespace TodoList
{
    public class TodoItemService
    {
        static TodoItemService()
        {
            _todoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Choose technology and programming language",
                IsItemComplete = true,
                ItemDetails = "Find the documentation and all the necessary materials",
                ItemId = _lastId

            });
            _todoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Learn Asp.Net Core",
                IsItemComplete = false,
                ItemDetails = "Learn theory and practice new things",
                ItemId = _lastId

            });
            _todoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Raise the level of knowledge in English",
                IsItemComplete = false,
                ItemDetails = "Read English literature and communicate with native speakers",
                ItemId = _lastId

            });
            _todoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Prepare for an interview",
                IsItemComplete = false,
                ItemDetails = "Repeat all the material",
                ItemId = _lastId

            });
        }
        private static readonly Dictionary<long, TodoItem> _todoItems
            = new Dictionary<long, TodoItem>();
        private static long _lastId = 0;
        public IEnumerable<TodoItem> GetAll() => _todoItems.Values;
        public TodoItem GetOne(long id) => _todoItems[id];
        public void Add(TodoItem todoItem)
        {
            todoItem.ItemId = ++_lastId;
            _todoItems.Add(todoItem.ItemId, todoItem);
        }
        public void Remove(long id) => _todoItems.Remove(id);
        public void Complete(long id)
        {
            _todoItems[id].IsItemComplete = true;
        }
    }
}
