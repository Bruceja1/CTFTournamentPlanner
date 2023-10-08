using Microsoft.AspNetCore.Identity;

namespace CTFTournamentPlanner.Models
{
    public class Player : IdentityUser
    {
        public int? TeamId { get; set; }
        public Team? Team { get; set; }
        public bool IsTeamLeader {  get; set; }
    }
}
