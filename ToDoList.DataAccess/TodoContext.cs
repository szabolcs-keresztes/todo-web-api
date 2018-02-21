using Microsoft.EntityFrameworkCore;
using ToDoList.DataAccess.Models;

namespace ToDoList.DataAccess
{
    public class TodoContext : DbContext
    {
        public TodoContext()
        { }

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        { }

        public DbSet<Todo> Todos { get; set; }
    }
}
