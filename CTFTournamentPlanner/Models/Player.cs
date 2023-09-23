using System.ComponentModel.DataAnnotations;

namespace CTFTournamentPlanner.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public Team? Team { get; set; }
    }
}
