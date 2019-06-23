using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Tables
{
   public class UnitType:BaseClass
    {

        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Priority { get; set; }

    }
}
