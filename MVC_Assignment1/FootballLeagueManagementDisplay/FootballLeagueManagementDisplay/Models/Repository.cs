using System.Collections.Generic;
using System.Linq;


namespace FootballLeagueManagementDisplay.Models
{
    public class Repository
    {
        public List<FootballLeagues> GetAllLeageDetails()
        {
            return new LeagueDBContext().FootballLeagues.ToList();
        }
    }
}