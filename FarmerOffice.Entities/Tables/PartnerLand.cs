using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Tables
{
 public   class PartnerLand:BaseClass
    {
        #region Properties
        public int CompanytId { get; set; }
        public bool IsActive { get; set; }
        public int PeriotId { get; set; }
        public int LandId { get; set; }
        public int PartnerCustomerId { get; set; }
        #endregion
    }
}
