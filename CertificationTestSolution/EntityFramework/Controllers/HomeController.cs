using EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var test = new AdventureWorksEntities();
            return View();
        }
    }
}