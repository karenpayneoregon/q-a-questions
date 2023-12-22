﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DumpObjectsApp.Data;
using DumpObjectsApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DumpObjectsApp.Data.Configurations
{
    public partial class ContactDevicesConfiguration : IEntityTypeConfiguration<ContactDevices>
    {
        public void Configure(EntityTypeBuilder<ContactDevices> entity)
        {
            entity.HasKey(e => e.ContactDeviceId);

            entity.HasIndex(e => e.ContactId, "IX_ContactDevices_ContactId");

            entity.HasIndex(e => e.PhoneTypeIdentifier, "IX_ContactDevices_PhoneTypeIdentifier");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactDevices)
            .HasForeignKey(d => d.ContactId)
            .HasConstraintName("FK_ContactDevices_Contacts1");

            entity.HasOne(d => d.PhoneTypeIdentifierNavigation).WithMany(p => p.ContactDevices)
            .HasForeignKey(d => d.PhoneTypeIdentifier)
            .HasConstraintName("FK_ContactDevices_PhoneType");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ContactDevices> entity);
    }
}
