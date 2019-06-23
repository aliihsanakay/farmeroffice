using FarmerOffice.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmerOffice.Entities.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
       
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("FO_COMPANY");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Code).HasColumnName("CODE");
            builder.Property(p => p.Name).HasColumnName("NAME");
            builder.Property(p => p.City).HasColumnName("CITY");
            builder.Property(p => p.Town).HasColumnName("TOWN");
            builder.Property(p => p.CreateDate).HasColumnName("CREATEDATE");
            builder.Property(p => p.CreateId).HasColumnName("CREATE_ID");
            builder.Property(p => p.EditDate).HasColumnName("EDITDATE");
            builder.Property(p => p.EditId).HasColumnName("EDIT_ID");
            builder.Property(p => p.Deleted).HasColumnName("DELETED");
        }
    }
}
