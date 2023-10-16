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

            List<Team> teams = new List<Team> 
            {
                new Team
                {
                    Id = 1,
                    Name = "Planeten",
                    Description = "Gewoon buitenaards goed!",
                },

                new Team
                {
                    Id = 2,
                    Name = "Flip Reset",
                    Description = "Wij zijn de betere auto's. Wij rijden niet alleen, wij vliegen naar de overwinning!",
                },

                new Team
                {
                    Id = 3,
                    Name = "Auto",
                    Description = "Waarom zou je naar de overwinning rennen als je naar de overwinning kunt rijden?"
                },

                new Team
                {
                    Id = 4,
                    Name = "Vlekkeloos",
                    Description = "Onze prestaties zijn te allen tijde vlekkeloos!"
                },

                new Team
                {
                    Id = 5,
                    Name = "Rusteze",
                    Description = "Ka-chow!"
                },

                new Team
                {
                    Id = 6,
                    Name = "Fruit",
                    Description = "Zoet of zuur, wij winnen elk uur!"
                },

                new Team
                {
                    Id = 7,
                    Name = "Vierpoten",
                    Description = "Wij rennen naar de overwinning!"
                },
            };
            foreach (Team team in teams)
            {
                modelBuilder.Entity<Team>().HasData(team);
            }

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Administrators",
                NormalizedName = "ADMINISTRATORS",
                Id = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5",
            });

            List<Player> players = new List<Player>
            {
                new Player
                {
                    Id = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                },

                new Player
                {
                    UserName = "aarde@example.com",
                    NormalizedUserName = "AARDE@EXAMPLE.COM",
                    Email = "aarde@example.com",
                    NormalizedEmail = "AARDE@EXAMPLE.COM",
                    TeamId = 1,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "mars@example.com",
                    NormalizedUserName = "MARS@EXAMPLE.COM",
                    Email = "mars@example.com",
                    NormalizedEmail = "MARS@EXAMPLE.COM",
                    TeamId = 1,
                },

                new Player
                {
                    UserName = "venus@example.com",
                    NormalizedUserName = "VENUS@EXAMPLE.COM",
                    Email = "venus@example.com",
                    NormalizedEmail = "VENUS@EXAMPLE.COM",
                    TeamId = 1,
                },

                new Player
                {
                    UserName = "mercurius@example.com",
                    NormalizedUserName = "MERCURIUS@EXAMPLE.COM",
                    Email = "mercurius@example.com",
                    NormalizedEmail = "MERCURIUS@EXAMPLE.COM",
                    TeamId = 1,
                },

                new Player
                {
                    UserName = "uranus@example.com",
                    NormalizedUserName = "URANUS@EXAMPLE.COM",
                    Email = "uranus@example.com",
                    NormalizedEmail = "URANUS@EXAMPLE.COM",
                    TeamId = 1,
                },

                new Player
                {
                    UserName = "neptunes@example.com",
                    NormalizedUserName = "NEPTUNES@EXAMPLE.COM",
                    Email = "neptunes@example.com",
                    NormalizedEmail = "NEPTUNES@EXAMPLE.COM",
                    TeamId = 1,
                },

                new Player
                {
                    UserName = "saturnus@example.com",
                    NormalizedUserName = "SATURNUS@EXAMPLE.COM",
                    Email = "saturnus@example.com",
                    NormalizedEmail = "SATURNUS@EXAMPLE.COM",
                    TeamId = 1,
                },

                new Player
                {
                    UserName = "jupiter@example.com",
                    NormalizedUserName = "JUPITER@EXAMPLE.COM",
                    Email = "jupiter@example.com",
                    NormalizedEmail = "JUPITER@EXAMPLE.COM",
                    TeamId = 1,
                },

                new Player
                {
                    UserName = "octane@example.com",
                    NormalizedUserName = "OCTANE@EXAMPLE.COM",
                    Email = "octane@example.com",
                    NormalizedEmail = "OCTANE@EXAMPLE.COM",
                    TeamId = 2,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "breakout@example.com",
                    NormalizedUserName = "BREAKOUT@EXAMPLE.COM",
                    Email = "breakout@example.com",
                    NormalizedEmail = "BREAKOUT@EXAMPLE.COM",
                    TeamId = 2,
                },

                new Player
                {
                    UserName = "dominus@example.com",
                    NormalizedUserName = "DOMINUS@EXAMPLE.COM",
                    Email = "dominus@example.com",
                    NormalizedEmail = "DOMINUS@EXAMPLE.COM",
                    TeamId = 2,
                },

                new Player
                {
                    UserName = "fennec@example.com",
                    NormalizedUserName = "FENNEC@EXAMPLE.COM",
                    Email = "fennec@example.com",
                    NormalizedEmail = "FENNEC@EXAMPLE.COM",
                    TeamId = 2,
                },

                new Player
                {
                    UserName = "volvo@example.com",
                    NormalizedUserName = "VOLVO@EXAMPLE.COM",
                    Email = "volvo@example.com",
                    NormalizedEmail = "VOLVO@EXAMPLE.COM",
                    TeamId = 3,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "volkswagen@example.com",
                    NormalizedUserName = "VOLKSWAGEN@EXAMPLE.COM",
                    Email = "volkswagen@example.com",
                    NormalizedEmail = "VOLKSWAGEN@EXAMPLE.COM",
                    TeamId = 3,
                },

                new Player
                {
                    UserName = "toyota@example.com",
                    NormalizedUserName = "TOYOTA@EXAMPLE.COM",
                    Email = "toyota@example.com",
                    NormalizedEmail = "TOYOTA@EXAMPLE.COM",
                    TeamId = 3,
                },

                new Player
                {
                    UserName = "ferrari@example.com",
                    NormalizedUserName = "FERRARI@EXAMPLE.COM",
                    Email = "ferrari@example.com",
                    NormalizedEmail = "FERRARI@EXAMPLE.COM",
                    TeamId = 3,
                },

                new Player
                {
                    UserName = "mercedes@example.com",
                    NormalizedUserName = "MERCEDES@EXAMPLE.COM",
                    Email = "mercedes@example.com",
                    NormalizedEmail = "MERCEDES@EXAMPLE.COM",
                    TeamId = 3,
                },

                new Player
                {
                    UserName = "bruce@example.com",
                    NormalizedUserName = "BRUCE@EXAMPLE.COM",
                    Email = "bruce@example.com",
                    NormalizedEmail = "BRUCE@EXAMPLE.COM",
                    TeamId = 4,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "mcqueen@example.com",
                    NormalizedUserName = "MCQUEEN@EXAMPLE.COM",
                    Email = "mcqueen@example.com",
                    NormalizedEmail = "MCQUEEN@EXAMPLE.COM",
                    TeamId = 5,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "mack@example.com",
                    NormalizedUserName = "MACK@EXAMPLE.COM",
                    Email = "mack@example.com",
                    NormalizedEmail = "MACK@EXAMPLE.COM",
                    TeamId = 5,
                },

                new Player
                {
                    UserName = "rusty@example.com",
                    NormalizedUserName = "RUSTY@EXAMPLE.COM",
                    Email = "rusty@example.com",
                    NormalizedEmail = "RUSTY@EXAMPLE.COM",
                    TeamId = 5,
                },

                new Player
                {
                    UserName = "dusty@example.com",
                    NormalizedUserName = "DUSTY@EXAMPLE.COM",
                    Email = "dusty@example.com",
                    NormalizedEmail = "DUSTY@EXAMPLE.COM",
                    TeamId = 5,
                },

                new Player
                {
                    UserName = "banaan@example.com",
                    NormalizedUserName = "BANAAN@EXAMPLE.COM",
                    Email = "banaan@example.com",
                    NormalizedEmail = "BANAAN@EXAMPLE.COM",
                    TeamId = 6,
                    IsTeamLeader= true,
                },

                new Player
                {
                    UserName = "citroen@example.com",
                    NormalizedUserName = "CITROEN@EXAMPLE.COM",
                    Email = "citroen@example.com",
                    NormalizedEmail = "CITROEN@EXAMPLE.COM",
                    TeamId = 6,
                },

                new Player
                {
                    UserName = "sinaasappel@example.com",
                    NormalizedUserName = "SINAASAPPEL@EXAMPLE.COM",
                    Email = "sinaasappel@example.com",
                    NormalizedEmail = "SINAASAPPEL@EXAMPLE.COM",
                    TeamId = 6,
                },

                new Player
                {
                    UserName = "watermeloen@example.com",
                    NormalizedUserName = "WATERMELOEN@EXAMPLE.COM",
                    Email = "watermeloen@example.com",
                    NormalizedEmail = "WATERMELOEN@EXAMPLE.COM",
                    TeamId = 6,
                },

                new Player
                {
                    UserName = "appel@example.com",
                    NormalizedUserName = "APPEL@EXAMPLE.COM",
                    Email = "appel@example.com",
                    NormalizedEmail = "APPEL@EXAMPLE.COM",
                    TeamId = 6,
                },

                new Player
                {
                    UserName = "peer@example.com",
                    NormalizedUserName = "PEER@EXAMPLE.COM",
                    Email = "peer@example.com",
                    NormalizedEmail = "PEER@EXAMPLE.COM",
                    TeamId = 6,
                },

                new Player
                {
                    UserName = "kiwi@example.com",
                    NormalizedUserName = "KIWI@EXAMPLE.COM",
                    Email = "kiwi@example.com",
                    NormalizedEmail = "KIWI@EXAMPLE.COM",
                    TeamId = 6,
                },

                new Player
                {
                    UserName = "avocado@example.com",
                    NormalizedUserName = "AVOCADO@EXAMPLE.COM",
                    Email = "avocado@example.com",
                    NormalizedEmail = "AVOCADO@EXAMPLE.COM",
                    TeamId = 6,
                },

                new Player
                {
                    UserName = "waterzwijn@example.com",
                    NormalizedUserName = "WATERZWIJN@EXAMPLE.COM",
                    Email = "waterzwijn@example.com",
                    NormalizedEmail = "WATERZWIJN@EXAMPLE.COM",
                    TeamId = 7,
                    IsTeamLeader = true,
                },

                new Player
                {
                    UserName = "huiskat@example.com",
                    NormalizedUserName = "HUISKAT@EXAMPLE.COM",
                    Email = "huiskat@example.com",
                    NormalizedEmail = "HUISKAT@EXAMPLE.COM",
                    TeamId = 7,
                },

                new Player
                {
                    UserName = "hyena@example.com",
                    NormalizedUserName = "HYENA@EXAMPLE.COM",
                    Email = "hyena@example.com",
                    NormalizedEmail = "HYENA@EXAMPLE.COM",
                    TeamId = 7,
                },

            };

            PasswordHasher<Player> ph = new PasswordHasher<Player>();          
            foreach (Player p in players)
            {
                p.PasswordHash = ph.HashPassword(p, "Pa$$w0rd");
                modelBuilder.Entity<Player>().HasData(p);
            }

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5",
                UserId = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
            });
            
        }
    }
}