using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Survey_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Everything You Wanted to Know, But Were Afraid to Ask";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "SurveyBoard Ltd.";

            return View();
        }
    }
}