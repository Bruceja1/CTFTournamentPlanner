using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CTFTournamentPlanner.Models;

namespace CTFTournamentPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext<CTFTournamentPlannerUser>
    {
        public DbSet<Team> Teams { get; set; }
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

            modelBuilder.Entity<Team>()
                .HasOne(e => e.TeamLeader)
                .WithMany()
                .HasForeignKey(e => e.TeamLeaderId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}