using System;
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
        public string Index(Paste p)
        {
            string pasteId = PasteManager.StorePaste(p);
            return Request.Url.Scheme + "://" + Request.Url.Authority + "/Home/DisplayPaste/" + pasteId;
        }

        [HttpGet]
        public ActionResult DisplayPaste(string id)
        {
            Paste p = PasteManager.GetPaste(id);
            return View("DisplayPage", p);
        }

        [HttpGet]
        public string GetRawPaste(string id)
        {
            return PasteManager.GetPaste(id).PasteData;
        }

        private static string PrettifyData(Paste p)
        {
            throw new NotImplementedException();
        }
    }
}