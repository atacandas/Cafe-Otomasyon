using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafe.MvcUI.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }
    }
}