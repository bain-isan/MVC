using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusDetailsDisplay.Models;
using System.Web.Mvc;

namespace BusDetailsDisplay.Controllers
{
    public class HomeController : Controller
    {
        Repository repository = new Repository();
        public ActionResult Index()
        { 
            var result = repository.GetAllBuses();
            var filter = result.Where(x => x.BoardingPoint == "MUM");
            return View("BusesFromMumbai", filter);
        }
    }
}