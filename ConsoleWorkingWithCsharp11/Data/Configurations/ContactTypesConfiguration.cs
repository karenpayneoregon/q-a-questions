using ConsoleWorkingWithCsharp11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleWorkingWithCsharp11.Data.Configurations
{
    public partial class ContactTypesConfiguration : IEntityTypeConfiguration<ContactTypes>
    {
        public void Configure(EntityTypeBuilder<ContactTypes> entity)
        {
            entity.HasKey(e => e.Identifier);

            entity.Property(e => e.ContactType).HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ContactTypes> entity);
    }
}
