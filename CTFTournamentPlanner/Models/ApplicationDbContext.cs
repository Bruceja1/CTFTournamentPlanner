using Microsoft.EntityFrameworkCore;
using System;

namespace CTFTournamentPlanner.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Bracket> Brackets { get; set; }
        public DbSet<Matchup> Matchups { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamLeader> TeamLeader { get; set; }
        public DbSet<Winner> Winner { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
