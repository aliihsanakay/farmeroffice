using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Tables
{
  public  class Users:BaseClass
    {
        #region Properties
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Tel { get; set; }
        public string Gsm { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        #endregion
    }
}
