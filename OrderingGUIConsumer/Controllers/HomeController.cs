using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderingGUIConsumer.Models;

namespace OrderingGUIConsumer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.agentName = "Welcome " + Session["agentName"];
            PortalModel details = new PortalModel();
            PortalModel getobj = new PortalModel();
            details = getobj.GetUsers();
            return View(details);
        }
        public ActionResult LoginStartPage()
        {
            return View();
        }
    }
}