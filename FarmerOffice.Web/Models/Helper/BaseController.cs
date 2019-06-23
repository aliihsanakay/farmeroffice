using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmerOffice.Entities.Context;
using Microsoft.AspNetCore.Mvc;

namespace FarmerOffice.Web.Models.Helper
{
    public class BaseController : Controller
    {
        public FarmerOfficeContext _context { get; set; }

        public BaseController()
        {

            if (_context == null)
                _context = new FarmerOfficeContext();
        }
    }
}