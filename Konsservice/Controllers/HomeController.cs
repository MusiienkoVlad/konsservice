using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Konsservice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactsView()
        {
            return View();
        }

        public ActionResult ServiceView()
        {
            return View();
        }

        public ActionResult ReportsView()
        {
            return View();
        }

        public ActionResult ClientsView()
        {
            return View();
        }

        public ActionResult SiteMapView()
        {
            return View();
        }
    }
}