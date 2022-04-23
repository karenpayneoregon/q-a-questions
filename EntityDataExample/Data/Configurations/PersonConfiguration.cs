using EntityDataExample.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using EntityDataExample.Models;

namespace EntityDataExample.Data.Configurations
{
    public partial class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> entity)
        {
            entity.HasOne(d => d.CountryIdentifierNavigation)
                .WithMany(p => p.Person)
                .HasForeignKey(d => d.CountryIdentifier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Person_Countries");

            entity.HasOne(d => d.OccupationIdentifierNavigation)
                .WithMany(p => p.Person)
                .HasForeignKey(d => d.OccupationIdentifier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Person_Occupation1");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Person> entity);
    }
}
