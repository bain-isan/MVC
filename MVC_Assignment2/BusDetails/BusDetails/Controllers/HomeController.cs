using System.Web.Mvc;
using BusDetails.Models;

namespace BusDetails.Controllers
{
    public class HomeController : Controller
    {
        Repository repository = new Repository();
        public ActionResult Index()
        {
            return View("AddBusData");
        }

        [HttpPost]
        public ActionResult Index(BusInfo busDetails)
        {
            if (ModelState.IsValid)
            {
                repository.InsertData(busDetails);
                ViewBag.Message = "Deta Saved Successfully...";
                return View("AddBusData");
            }

            ViewBag.Message = "Something Went Wrong...";
            return View("AddBusData");
        }
    }
}