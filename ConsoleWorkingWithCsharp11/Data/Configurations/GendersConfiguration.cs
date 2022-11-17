using ConsoleWorkingWithCsharp11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleWorkingWithCsharp11.Data.Configurations
{
    public partial class GendersConfiguration : IEntityTypeConfiguration<Genders>
    {
        public void Configure(EntityTypeBuilder<Genders> entity)
        {
            entity.Property(e => e.Id).HasColumnName("id");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Genders> entity);
    }
}
