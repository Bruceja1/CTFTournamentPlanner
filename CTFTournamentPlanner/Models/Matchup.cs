using System.ComponentModel.DataAnnotations;

namespace CTFTournamentPlanner.Models
{
    public class Matchup
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public int? ScoreA { get; set; } = 0;
        [MaxLength(100)]
        public int? ScoreB { get; set;} = 0;
        public ICollection<Team>? Teams { get; set; }
        public Round Round { get; set; }
        public int? RoundId { get; set; }
    }
}
