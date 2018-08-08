using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityCodeFirstApproach.Models;

namespace EntityCodeFirstApproach.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        DbContext1 db = new DbContext1();
        
        [HttpGet]
        public ActionResult Index()
        {
            db.Catagorytable.ToList();
            db.ProductTable.ToList();

            return View();
        }
    }
}