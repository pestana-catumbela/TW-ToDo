using Microsoft.EntityFrameworkCore;
using TW_ToDo.Models;

namespace TW_ToDo.Contexts;

public class TWTodoContext : DbContext
{
    public DbSet<Todo> Todo => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todo.sqlite3");
    }
}