namespace CTFTournamentPlanner.Models
{
    public class Round
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Matchup>? Matchups { get; set; }
    }
}
