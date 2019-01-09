using System.Collections.Generic;

namespace TodoList
{
    public class TodoItemService
    {
        static TodoItemService()
        {
            _todoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Open Visual Studio",
                IsItemComplete = true,
                ItemDetails = "Open VS programm",
                ItemId = _lastId

            });
            _todoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Code in Visual Studio",
                IsItemComplete = true,
                ItemDetails = "Code in VS programm",
                ItemId = _lastId

            });
            _todoItems.Add(++_lastId, new TodoItem
            {
                ItemName = "Close Visual Studio",
                IsItemComplete = true,
                ItemDetails = "Close VS programm",
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
