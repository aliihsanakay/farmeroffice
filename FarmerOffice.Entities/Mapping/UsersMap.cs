using FarmerOffice.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Mapping
{
    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("CO_USERS");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.CompanyId).HasColumnName("COMPANY_ID");
            builder.Property(p => p.Code).HasColumnName("CODE");
            builder.Property(p => p.Name).HasColumnName("NAME");
            builder.Property(p => p.Surname).HasColumnName("SURNAME");
            builder.Property(p => p.EMail).HasColumnName("EMAIL");
            builder.Property(p => p.Tel).HasColumnName("TEL");
            builder.Property(p => p.Gsm).HasColumnName("GSM");
            builder.Property(p => p.Gender).HasColumnName("GENDER");
            builder.Property(p => p.CreateId).HasColumnName("CREATE_ID");
            builder.Property(p => p.CreateDate).HasColumnName("CREATEDATE");
            builder.Property(p => p.EditDate).HasColumnName("EDITDATE");
            builder.Property(p => p.EditId).HasColumnName("EDIT_ID");
            builder.Property(p => p.Deleted).HasColumnName("DELETED");
            builder.Property(p => p.IsActive).HasColumnName("ISACTIVE");
            builder.Property(p => p.Password).HasColumnName("PASSWORD");
        }
    }
}
