using FarmerOffice.Entities.Mapping;
using FarmerOffice.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Context
{
   public class FarmerOfficeContext:DbContext
    {
        
        public DbSet<Company> FO_COMPANY { get; set; }
        public DbSet<UnitType> FO_UNIT_TYPE { get; set; }
        protected override void OnModelCreating(ModelBuilder modedlBuilder)
        {
            modedlBuilder.ApplyConfiguration(new CompanyMap());
            modedlBuilder.ApplyConfiguration(new UnitTypeMap());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=185.86.15.138;Initial Catalog=fo;User ID=sa;Password=WellDown#1;");
        }
    }
}
