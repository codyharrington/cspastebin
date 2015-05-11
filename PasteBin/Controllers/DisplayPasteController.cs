using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PasteBin.Controllers
{
    public class DisplayPasteController : Controller
    {
        // GET: DisplayPaste
        public ActionResult Index(string id)
        {
            return View();
        }
    }
}