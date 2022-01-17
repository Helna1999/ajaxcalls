using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajaxcalls.Controllers
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

        public ActionResult Test()
        {

            return View();
        }

        public JsonResult Math(int nr1 , int nr2)
        {
            var result = nr1 + nr2;
            /*var data = new { status = "ok", result = result };*/
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}