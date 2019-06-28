using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmerOffice.Entities.Context;
using FarmerOffice.Entities.Tables;
using FarmerOffice.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace FarmerOffice.Web.Models.Helper
{
    public class BaseController : Controller
    {
        public Users CurrentUser
        {
            get { return HttpContext.Session.GetObject<Users>("CurrentUser"); }
            set { HttpContext.Session.SetObject("CurrentUser", value); }
        }
        public FarmerOfficeContext _context { get; set; }

        public BaseController()
        {

            if (_context == null)
                _context = new FarmerOfficeContext();
        }
    }
}