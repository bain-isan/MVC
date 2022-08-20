using System.Web.Mvc;
using FootblallLeagueManagement.Models;


namespace FootblallLeagueManagement.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult AddMatchResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMatchResult(FootballLeague footballLeague)
        {
            if (ModelState.IsValid)
            {
                FootballLeagueRepository repository = new FootballLeagueRepository();
                repository.AddLeagueDetails(footballLeague);
                ViewBag.Message = "Match Details Successfully Saved...";

                return View();
            }
            
            ViewBag.Message = "Something Went Wrong...";
            return View();
        }
    }
}