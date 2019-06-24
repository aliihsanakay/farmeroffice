using FarmerOffice.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Mapping
{
    public class CustomerCategoryMap : IEntityTypeConfiguration<CustomerCategory>
    {
        public void Configure(EntityTypeBuilder<CustomerCategory> builder)
        {
            builder.ToTable("FO_CUSTOMER_CATEGORY");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Name).HasColumnName("NAME");
            builder.Property(p => p.IsActive).HasColumnName("ISACTIVE");
            builder.Property(p => p.CreateId).HasColumnName("CREATE_ID");
            builder.Property(p => p.CreateDate).HasColumnName("CREATEDATE");
            builder.Property(p => p.EditId).HasColumnName("EDIT_ID");
            builder.Property(p => p.EditDate).HasColumnName("EDITDATE");
            builder.Property(p => p.Deleted).HasColumnName("DELETED");
        }
    }
}
