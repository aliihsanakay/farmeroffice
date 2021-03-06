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
using FarmerOffice.Web.Models.Helper;
using System.Linq.Expressions;
using FarmerOffice.Web.Helper;

namespace FarmerOffice.Web.Controllers
{
    public class HomeController : BaseController
    {

        public List<Company> CurrentCompany
        {
            get { return HttpContext.Session.GetObject<List<Company>>("CurrentCompany"); }
            set { HttpContext.Session.SetObject("CurrentCompany", value); }
        }

        public IActionResult Index()
        {
            //  CompanyDAL companyDAL = new CompanyDAL();
            //var item = companyDAL.GetAll(_context);
            //Company  item1 = item.FirstOrDefault();

            //  item1.Name = "Ali Update";
            //              companyDAL.Update(_context,item1);
            //  companyDAL.Save(_context);

            Company itemd = new Company()
            {
                Id = 3
            };
            CurrentCompany.Add(itemd);


            //companyDAL.Delete(_context, x=>x.Id==1);
            //companyDAL.Save(_context);




            CompanyDAL companyDAL = new CompanyDAL();
            //Company company = new Company();
            //company.Name = "Ali Tarım";
            //company.Code = "C0001";
            //company.City = "Antalya";
            //company.Town = "Demre";
            //companyDAL.Add(_context, company);
            //companyDAL.Save(_context);

           var item= companyDAL.GetById(2,false);

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
