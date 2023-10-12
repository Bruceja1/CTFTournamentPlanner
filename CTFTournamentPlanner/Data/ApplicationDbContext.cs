using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CTFTournamentPlanner.Models;

namespace CTFTournamentPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext<Player>
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Bracket> Brackets { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}