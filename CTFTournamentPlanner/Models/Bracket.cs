namespace CTFTournamentPlanner.Models
{
    public class Bracket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Team>? Teams { get; set; }
        public ICollection<Round>? Rounds { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsGenerated { get; set; } = false;
    }
}
