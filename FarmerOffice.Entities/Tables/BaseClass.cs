using FarmerOffice.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmerOffice.Entities.Tables
{
   public class BaseClass:IEntity
    {
        #region Properties
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate   { get; set; }
        public int CreateId { get; set; }
        public int? EditId { get; set; }
        public bool  Deleted { get; set; }
        #endregion
        public BaseClass()
        {
          
            CreateDate = DateTime.Now;
            CreateId = -1;
            EditId = -1;
        }
    }
}
