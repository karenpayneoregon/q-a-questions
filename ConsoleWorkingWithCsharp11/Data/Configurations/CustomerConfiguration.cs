using ConsoleWorkingWithCsharp11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleWorkingWithCsharp11.Data.Configurations
{
    public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.HasKey(e => e.Identifier);

            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.ContactFirstName).HasMaxLength(255);
            entity.Property(e => e.ContactLastName).HasMaxLength(255);

            entity.HasOne(d => d.ContactTypeIdentifierNavigation).WithMany(p => p.Customer)
            .HasForeignKey(d => d.ContactTypeIdentifier)
            .HasConstraintName("FK_Customer_ContactTypes");

            entity.HasOne(d => d.GenderIdentifierNavigation).WithMany(p => p.Customer)
            .HasForeignKey(d => d.GenderIdentifier)
            .HasConstraintName("FK_Customer_Genders");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Customer> entity);
    }
}
