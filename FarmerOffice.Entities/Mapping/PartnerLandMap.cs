using FarmerOffice.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Mapping
{
    public class PartnerLandMap : IEntityTypeConfiguration<PartnerLand>
    {
        public void Configure(EntityTypeBuilder<PartnerLand> builder)
        {
            builder.ToTable("COP_PARTNER_LAND");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.CompanytId).HasColumnName("COMPANY_ID");
            builder.Property(p => p.IsActive).HasColumnName("ISACTIVE");
            builder.Property(p => p.CreateId).HasColumnName("CREATE_ID");
            builder.Property(p => p.CreateDate).HasColumnName("CREATEDATE");
            builder.Property(p => p.EditId).HasColumnName("EDIT_ID");
            builder.Property(p => p.EditDate).HasColumnName("EDITDATE");
            builder.Property(p => p.Deleted).HasColumnName("DELETED");
            builder.Property(p => p.PeriotId).HasColumnName("PERIOT_ID");
            builder.Property(p => p.LandId).HasColumnName("LAND_ID");
            builder.Property(p => p.PartnerCustomerId).HasColumnName("PARTNER_CUSTOMER_ID");
        }
    }
}
