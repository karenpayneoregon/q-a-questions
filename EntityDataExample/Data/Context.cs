using Microsoft.EntityFrameworkCore;
using EntityDataExample.Models;
using EntityFrameworkCoreHelpers.Classes;

#nullable disable

#nullable disable

namespace EntityDataExample.Data
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Occupation> Occupation { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                DbContextConnections.NoLogging(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new Configurations.CountriesConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OccupationConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PersonConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
