using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC1_CustomerCenter.Models;

namespace MVC1_CustomerCenter.Controllers
{
    public class CustomerSummaryInfoesController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: CustomerSummaryInfoes
        public ActionResult Index()
        {
            return View(db.CustomerSummaryInfo.ToList());
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
