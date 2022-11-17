using ConfigurationLibrary.Classes;
using ConsoleWorkingWithCsharp11.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConsoleWorkingWithCsharp11.Data;

public partial class Context : DbContext
{
    public Context()
    {
        // remove this for ASP.NET Core scaffolding
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ContactTypes> ContactTypes { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<Genders> Genders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationHelper.ConnectionString());
        //=> optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=CustomerDatabase1;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.ApplyConfiguration(new Configurations.ContactTypesConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.GendersConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
