using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DataModel;
using System.Data.Entity;

namespace WebServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Database.SetInitializer<DataContext>(new DbInitializer());
            return View();
        }
    }
}
