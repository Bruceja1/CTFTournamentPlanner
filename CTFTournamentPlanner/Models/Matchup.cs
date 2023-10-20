using System.ComponentModel.DataAnnotations;

namespace CTFTournamentPlanner.Models
{
    public class Matchup
    {
        public int Id { get; set; }      
        public int? ScoreA { get; set; } = 0;      
        public int? ScoreB { get; set;} = 0;
        public ICollection<Team>? Teams { get; set; }
        public Round? Round { get; set; }
        public int? RoundId { get; set; }

        // Onderste twee variabelen zijn voor het opslaan van het geselecteerde team wanneer een matchup geüpdatet wordt door de admin.
        public int? SelectedTeamAId { get; set; }
        public int? SelectedTeamBId { get; set; }
    }
}
