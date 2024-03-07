using Avadone_ia.Domain;
using Microsoft.EntityFrameworkCore;

namespace Avadone_ia.Infrastructure.Database;

public class AvadoneiaContext : DbContext
{
    #region EF_Tables
    public DbSet<ToDo> ToDo => Set<ToDo>();
    public DbSet<ToDoItem> ToDoItem => Set<ToDoItem>();
    #endregion

    
    public AvadoneiaContext() : this(new DbContextOptions<AvadoneiaContext>())
    { }

    public AvadoneiaContext(DbContextOptions<AvadoneiaContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=userdata.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ToDo>().HasNoKey();
        modelBuilder.Entity<ToDoItem>().HasNoKey();
    }
}