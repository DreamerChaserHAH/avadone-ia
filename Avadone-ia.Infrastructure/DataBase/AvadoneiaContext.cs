using Avadone_ia.Domain;
using Microsoft.EntityFrameworkCore;

namespace Avadone_ia.Infrastructure.DB;

public class AvadoneiaContext : DbContext
{
    #region EF_Tables
    public DbSet<ToDo> ToDo => Set<ToDo>();
    public DbSet<ToDoItem> ToDoItem => Set<ToDoItem>();
    #endregion

    public AvadoneiaContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=userdata.db");
    }
}