using FarmerOffice.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Mapping
{
    public class UnitTypeMap : IEntityTypeConfiguration<UnitType>
    {
        public void Configure(EntityTypeBuilder<UnitType> builder)
        {
            builder.ToTable("FO_UNIT_TYPE");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Name).HasColumnName("NAME");
            builder.Property(p => p.IsActive).HasColumnName("ISACTIVE");
            builder.Property(p => p.Priority).HasColumnName("PRIORITY");
            builder.Property(p => p.Deleted).HasColumnName("DELETED");
        }
    }
}
