
using SelfDestructAjax.Models;
using SelfDestructAjax.Mockup;
using SelfDestructAjax.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfDestructAjax.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();

            model.PageTitle = "Mission Impossible Self Destruct";

            return View(model);
        }

    [HttpGet]
       public JsonResult GetMissionCountdownResponse()
       {
         return new JsonResult().SerializeObject(MockCountdown.MissionCountdownResponse);
       }

    }
}
