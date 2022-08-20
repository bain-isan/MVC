using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootblallLeagueManagement.Models
{
    public class FootballLeagueDBContext : DbContext
    { 
        public FootballLeagueDBContext()
            : base("name = Conn1"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FootballLeague>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FootballLeague> FootballLeagues { get; set; }
    }
}