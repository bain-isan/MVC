using System;


namespace FootblallLeagueManagement.Models
{
    public class FootballLeagueRepository
    { 
        public void AddLeagueDetails(FootballLeague footballLeague)
        {
            //try
            //{
                FootballLeagueDBContext conn = new FootballLeagueDBContext();

                conn.FootballLeagues.Add(footballLeague);
                conn.SaveChanges();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
        }
    }
}