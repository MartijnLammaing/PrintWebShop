using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrintWebShop.Data.DatabaseConfigurations;

namespace PrintWebShop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using(var db = new TestContext())
            {
                return View();
            }
        }

    }
}
