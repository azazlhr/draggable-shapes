using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DraggableInteractiveDivs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult AddShape()
        {
            return View();
        }

        public ActionResult MoveShape()
        {
            return View();
        }
    }
}