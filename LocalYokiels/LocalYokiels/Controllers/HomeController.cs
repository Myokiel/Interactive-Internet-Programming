using LocalYokiels.Models;
using System.Web.Mvc;

namespace LocalYokiels.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.PageTitle = "Local Yokiels Page";
            return View(model);
        }

    }
}
