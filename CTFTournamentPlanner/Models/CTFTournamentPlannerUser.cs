using Microsoft.AspNetCore.Identity;

namespace CTFTournamentPlanner.Models
{
    public class CTFTournamentPlannerUser : IdentityUser
    {
        // currentUser.TeamId (TeamsController.cs) is niet mogelijk (dankjewel EF...)
        // Dus extra property hieronder om het Team Id van een gebruiker op te vragen. 
        public int? UserTeamId { get; set; }
    }
}
