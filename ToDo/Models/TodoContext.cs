using Microsoft.EntityFrameworkCore;

namespace ToDo.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoTask> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=todo.db");
    }
}