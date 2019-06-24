using FarmerOffice.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Mapping
{
    public class LicenceTypeMap : IEntityTypeConfiguration<LicenceType>
    {
        public void Configure(EntityTypeBuilder<LicenceType> builder)
        {

            builder.ToTable("FO_LICENCE_TYPE");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Name).HasColumnName("NAME");
        }
    }
}
