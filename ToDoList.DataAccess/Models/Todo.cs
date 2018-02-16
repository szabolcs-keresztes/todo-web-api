using System;

namespace ToDoList.DataAccess.Models
{
    public class Todo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsCompleted { get; set; }
    }
}
