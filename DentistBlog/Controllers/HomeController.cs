﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentistBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Anasayfa()
        {
            return View();
        }
    }
}