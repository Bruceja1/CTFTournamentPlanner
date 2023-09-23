namespace CTFTournamentPlanner.Models
{
    public class Matchup
    {
        public int Id { get; set; }
        public ICollection<Team> Teams { get; set;}
        public int Score { get; set; }
    }
}
