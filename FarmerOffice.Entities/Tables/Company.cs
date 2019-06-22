using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Tables
{
  public  class Company:BaseClass
    {
        #region Propeties
        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        #endregion
    }
}
