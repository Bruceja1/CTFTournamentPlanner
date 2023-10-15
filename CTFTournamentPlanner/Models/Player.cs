using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTFTournamentPlanner.Models
{
    public class Player : IdentityUser
    {
        public int? TeamId { get; set; }
        public Team? Team { get; set; }
        [Column]
        public bool IsTeamLeader { get; set; } = false;
    }
}
