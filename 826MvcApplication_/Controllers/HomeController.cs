﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _826MvcApplication_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult 
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!haha";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
