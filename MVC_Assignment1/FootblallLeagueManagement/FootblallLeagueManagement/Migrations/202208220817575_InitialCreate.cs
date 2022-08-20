namespace FootblallLeagueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootballLeagues",
                c => new
                    {
                        MatchId = c.Int(nullable: false),
                        TeamName1 = c.String(nullable: false),
                        TeamName2 = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        WinningTeam = c.String(),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchId);
            
            CreateStoredProcedure(
                "dbo.FootballLeague_Insert",
                p => new
                    {
                        MatchId = p.Int(),
                        TeamName1 = p.String(),
                        TeamName2 = p.String(),
                        Status = p.String(),
                        WinningTeam = p.String(),
                        Points = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[FootballLeague]([MatchId], [TeamName1], [TeamName2], [Status], [WinningTeam], [Points])
                      VALUES (@MatchId, @TeamName1, @TeamName2, @Status, @WinningTeam, @Points)"
            );
            
            CreateStoredProcedure(
                "dbo.FootballLeague_Update",
                p => new
                    {
                        MatchId = p.Int(),
                        TeamName1 = p.String(),
                        TeamName2 = p.String(),
                        Status = p.String(),
                        WinningTeam = p.String(),
                        Points = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[FootballLeague]
                      SET [TeamName1] = @TeamName1, [TeamName2] = @TeamName2, [Status] = @Status, [WinningTeam] = @WinningTeam, [Points] = @Points
                      WHERE ([MatchId] = @MatchId)"
            );
            
            CreateStoredProcedure(
                "dbo.FootballLeague_Delete",
                p => new
                    {
                        MatchId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[FootballLeague]
                      WHERE ([MatchId] = @MatchId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.FootballLeague_Delete");
            DropStoredProcedure("dbo.FootballLeague_Update");
            DropStoredProcedure("dbo.FootballLeague_Insert");
            DropTable("dbo.FootballLeagues");
        }
    }
}
