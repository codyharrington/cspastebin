﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PasteBin.Models;

namespace PasteBin.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(Paste p)
        {
            return View("DisplayPage", p);
        }

        [HttpGet]
        public ActionResult GetPaste(string id)
        {
            return View("DisplayPage");
        }

        [HttpGet]
        public ActionResult GetRawPaste(string id)
        {
            return View("DisplayPage");
        }

        private static string PrettifyData(Paste p)
        {
            throw new NotImplementedException();
        }
    }
}