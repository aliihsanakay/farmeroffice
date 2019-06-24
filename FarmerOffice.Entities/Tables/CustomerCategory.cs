using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Tables
{
   public class CustomerCategory:BaseClass
    {
        #region Properties
        public bool IsActive { get; set; }
        public string Name { get; set; }
              
        #endregion
    }
}
