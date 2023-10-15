using System.ComponentModel.DataAnnotations;

namespace CTFTournamentPlanner.Models
{
    public class Matchup
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public int? ScoreA { get; set; } = null;
        [MaxLength(100)]
        public int? ScoreB { get; set;} = null;
        public ICollection<Team>? Teams { get; set; }
        public int? RoundId { get; set; }
    }
}
