using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FootblallLeagueManagement.Models.Validations;

namespace FootblallLeagueManagement.Models
{
    [Table("FootballLeagues")]
    public class FootballLeague
    {
        [Required(ErrorMessage = "Please Enter Match Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchId { get; set; }


        [Required(ErrorMessage = "Please Enter Match Id")]
        [Column("TeamName1")]
        public string TeamName1 { get; set; }


        [Required(ErrorMessage = "Please Enter Match Id")]
        [Column("TeamName2")]
        public string TeamName2 { get; set; }


        [Required(ErrorMessage = "Please Enter Match Id")]
        [StatusValidation]
        [Column("Status")]
        public string Status { get; set; }

        [Column("WinningTeam")]
        public string WinningTeam { get; set; }


        [Required(ErrorMessage = "Please Enter Match Id")]
        [Column("Points")]
        public int Points { get; set; }
    }
}