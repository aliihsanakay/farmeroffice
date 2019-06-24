using FarmerOffice.Entities.Context;
using FarmerOffice.Entities.Tables;
using FarmerOffice.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FarmerOffice.Entities.Data_Access
{
    public class CompanyDAL :EntityRepositoryBase<FarmerOfficeContext, Company>
    {
        public   Company GetById(int pId,bool pDeleted)
        {
            Company company =new Company();
            var list = ExecuteReader(company, "Getlist_Ali", MethodBase.GetCurrentMethod().GetParameters(), new object[] { pId , pDeleted });
            return list.First();
        }
    }
}
