using System.Linq;
using FootballLeagueManagementDisplay.Models;
using System.Web.Mvc;

namespace FootballLeagueManagementDisplay.Controllers
{
    public class HomeController : Controller
    {
        Repository repository = new Repository();
        public ActionResult Index()
        {
            var result = repository.GetAllLeageDetails();
            var filter = result.Where(x => x.Status == "Win" || x.Status == "WIN");
            return View("LeagueDetails", filter);
        }
    }
}