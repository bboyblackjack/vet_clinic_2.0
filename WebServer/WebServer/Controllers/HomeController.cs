using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DataModel;

namespace WebServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ColorRepository _rep = new ColorRepository();
            _rep.Add(new Color
                {
                    Name = "Черный"
                });
            return View();
        }
    }
}
