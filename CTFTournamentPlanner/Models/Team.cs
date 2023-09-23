using System.ComponentModel.DataAnnotations;

namespace CTFTournamentPlanner.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(50)]
        public string? Slogan { get; set; }
        public ICollection<Player>? Players { get; set; }
    }
}
