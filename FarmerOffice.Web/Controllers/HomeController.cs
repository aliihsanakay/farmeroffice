﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmerOffice.Web.Models;
using FarmerOffice.Entities.Context;
using FarmerOffice.Entities.Data_Access;
using FarmerOffice.Entities.Tables;

namespace FarmerOffice.Web.Controllers
{
    public class HomeController : Controller
    {
        FarmerOfficeContext _context = new FarmerOfficeContext();
        public IActionResult Index()
        {

            //CompanyDAL companyDAL = new CompanyDAL();
            //Company company = new Company();
            //company.Name = "Ali Tarım";
            //company.Code = "C0001";
            //company.City = "Antalya";
            //company.Town = "Demre";
            //companyDAL.AddOrUpdate(_context,company);
            //companyDAL.Save(_context);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
