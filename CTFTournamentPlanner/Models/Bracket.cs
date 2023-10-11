namespace CTFTournamentPlanner.Models
{
    public class Bracket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Team>? Teams { get; set; }
    }
}
