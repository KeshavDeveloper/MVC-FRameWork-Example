using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult create()
        {
            return View();
        }
        //public ActionResult InlineHtmlHelper()
        //{
        //    return View();

        //}
    }


}