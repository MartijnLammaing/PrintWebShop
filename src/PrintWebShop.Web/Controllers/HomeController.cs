using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using PrintWebShop.Models;
using PrintWebShop.Services;

namespace PrintWebShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new HomeVM();
            return View(model);
        }
    }
}