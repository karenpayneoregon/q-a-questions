using EntityDataExample.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using EntityDataExample.Models;

namespace EntityDataExample.Data.Configurations
{
    public partial class OccupationConfiguration : IEntityTypeConfiguration<Occupation>
    {
        public void Configure(EntityTypeBuilder<Occupation> entity)
        {
            entity.HasKey(e => e.OccupationIdentifier);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Occupation> entity);
    }
}
