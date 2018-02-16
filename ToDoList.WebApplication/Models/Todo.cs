using System;

namespace ToDoList.WebApplication.Models
{
    public class Todo
    {
        public Guid Id { get; set; }

        public string Task { get; set; }

        public bool IsCompleted { get; set; }
    }
}
