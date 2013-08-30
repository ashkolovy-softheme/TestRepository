using System.Web.Mvc;

namespace TestApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application. HotFix1";
            ViewBag.SomeNewFeature3 = "SomeNewFeature3";
            ViewBag.SomeNewFeature2 = "SomeNewFeature2";
            ViewBag.SomeNewFeature4 = "SomeNewFeature4";
            ViewBag.SomeNewFeature1 = "SomeNewFeature1";
            ViewBag.SomeNewFeature1 = "SomeNewFeature5";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
