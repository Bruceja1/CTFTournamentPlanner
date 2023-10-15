using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CTFTournamentPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace CTFTournamentPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext<Player>
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Bracket> Brackets { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Matchup> Matchups { get; set; }
        
        private readonly UserManager<Player> userManager;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // optionsBuilder.UseSqlServer(options => options.EnableRetryOnFailure());
        }
        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Team fireboss = new Team()
            {
                Id = 1,
                Name = "Fireboss",
                Description = "Het beste team.",
            };

            Team flipreset = new Team()
            {
                Id = 2,
                Name = "Flip Reset",
                Description = "glhf",
            };

            modelBuilder.Entity<Team>().HasData(fireboss, flipreset);
                
            var Bruce = new Player
            {
                UserName = "Bruce",               
                Email = "bruce@example.com",
                EmailConfirmed = true,
                TeamId = 1,
                IsTeamLeader = true,
            };

            var Octane = new Player
            {
                UserName = "Octane",
                Email = "octane@example.com",
                EmailConfirmed = true,
                TeamId = 2,
                IsTeamLeader = true
            };

            PasswordHasher<Player> ph = new PasswordHasher<Player>();
            Bruce.PasswordHash = ph.HashPassword(Bruce, "Pa$$w0rd");
            Octane.PasswordHash = ph.HashPassword(Octane, "Pa$$w0rd");

            modelBuilder.Entity<Player>().HasData(Bruce, Octane);
             
            /*
            List<Player> players = new List<Player>
            {
                new Player
                {
                    UserName = "Bruce",
                    Email = "bruce@example.com",
                    TeamId = 1,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "Bruce2",
                    Email = "bruce2@example.com",
                    TeamId = 1,
                    IsTeamLeader = false,
                },

                new Player
                {
                    UserName = "Octane",
                    Email = "octane@example.com",
                    TeamId = 2,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "Breakout",
                    Email = "breakout@example.com",
                    TeamId = 2,
                    IsTeamLeader = false,
                },

                new Player
                {
                    UserName = "Dominus",
                    Email = "dominus@example.com",
                    TeamId = 2,
                    IsTeamLeader = false,
                },              
            };

            foreach (Player p in players)
            {
                Player player = new Player
                {
                    UserName = p.UserName,
                    Email = p.Email,
                    TeamId = p.TeamId,
                    IsTeamLeader = p.IsTeamLeader,
                };

                var result = await userManager.CreateAsync(player, "Pa$$w0rd");

                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(player);
                    await userManager.ConfirmEmailAsync(player, token);
                }
            }
            */

            
            
        }
    }
}