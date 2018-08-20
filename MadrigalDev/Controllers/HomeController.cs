using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MadrigalDev.Hubs;
using MadrigalDev_DAL;

namespace MadrigalDev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Data()
        {
            madrigaldev_testEntities data = new madrigaldev_testEntities();
            var datos = data.t_empresa.ToList();
            return PartialView("_DataList", datos);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(t_empresa model)
        {
            madrigaldev_testEntities context = new madrigaldev_testEntities();
            var added = context.t_empresa.Add(model);
            context.SaveChanges();
            CustomerHub.BroadcastData();
            return View("Insert");
        }
    }
}