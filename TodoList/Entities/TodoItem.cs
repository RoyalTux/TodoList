namespace TodoList.Entities
{
    public class TodoItem
    {
        public long ItemId { get; set; }

        public string ItemName { get; set; }

        public string ItemDetails { get; set; }

        public bool IsItemComplete { get; set; }
    }
}
