using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410716649.Controllers
{
    public class WaterController : Controller
    {
        public ActionResult Water(string name, float? weight)
        {
            var result = "";
            if (weight.HasValue)
            {
                result = (weight * 30) + "cc";
            }

            ViewBag.name = name;
            ViewBag.Result = result;

            return View();
        }
    }
}
