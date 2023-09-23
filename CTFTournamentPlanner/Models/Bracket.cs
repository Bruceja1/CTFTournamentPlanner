using System.ComponentModel.DataAnnotations;

namespace CTFTournamentPlanner.Models
{
    public class Bracket
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }    
        public ICollection<Round>? Rounds { get; set; }
    }
}
