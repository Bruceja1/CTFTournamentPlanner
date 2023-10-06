using Microsoft.AspNetCore.Identity;

namespace CTFTournamentPlanner.Models
{
    public class CTFTournamentPlannerUser
    {
        [PersonalData]
        public int TeamId { get; set; }
    }
}
