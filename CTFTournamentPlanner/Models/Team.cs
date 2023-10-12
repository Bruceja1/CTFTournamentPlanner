using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CTFTournamentPlanner.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Player>? Players { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public ICollection<Bracket> Brackets { get; set; }
    }
}
