namespace CTFTournamentPlanner.Models
{
    public class Round
    {
        public int Id { get; set; }
        public ICollection<Matchup>? Matchups { get; set; }
    }
}
