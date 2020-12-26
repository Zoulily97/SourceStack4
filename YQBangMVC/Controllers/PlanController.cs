using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YQBangMVC.Controllers
{
    public class PlanController : Controller
    {
        // GET: Plan
        public ActionResult New()
        {
            return View();
        }
    }
}