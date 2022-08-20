namespace FootblallLeagueManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FootblallLeagueManagement.Models.FootballLeagueDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FootblallLeagueManagement.Models.FootballLeagueDBContext";
        }

        protected override void Seed(FootblallLeagueManagement.Models.FootballLeagueDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
