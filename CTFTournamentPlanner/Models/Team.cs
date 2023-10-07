using Microsoft.AspNetCore.Identity;

namespace CTFTournamentPlanner.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CTFTournamentPlannerUser> Players { get; set; } = new List<CTFTournamentPlannerUser>();
        public CTFTournamentPlannerUser? TeamLeader { get; set; }
        public string? TeamLeaderId { get; set; }

        public Team()
        {
            Players = new List<CTFTournamentPlannerUser>();
        }
    }
}
