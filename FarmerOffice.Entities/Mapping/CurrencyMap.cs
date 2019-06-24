using FarmerOffice.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Mapping
{
    public class CurrencyMap : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("FO_CURRENCY");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Code).HasColumnName("CODE");
            builder.Property(p => p.CreateDate).HasColumnName("CREATEDATE");
            builder.Property(p => p.CreateId).HasColumnName("CREATE_ID");
            builder.Property(p => p.EditDate).HasColumnName("EDITDATE");
            builder.Property(p => p.EditId).HasColumnName("EDIT_ID");
            builder.Property(p => p.Deleted).HasColumnName("DELETED");
            builder.Property(p => p.Name).HasColumnName("NAME");
        }
    }
}
