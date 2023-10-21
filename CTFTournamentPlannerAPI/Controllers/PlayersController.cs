using CTFTournamentPlanner.Data;
using CTFTournamentPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CTFTournamentPlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Player> userManager;
        public PlayersController(ApplicationDbContext context, UserManager<Player> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> Get()
        {
            var players = await _context.Users.ToListAsync();

            return players;
        }

        // GET api/<UsersController>/5
        [HttpGet("{email}")]
        public async Task<ActionResult<Player>> Get(string email)
        {
            Player player = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (player == null)
            {
                return NotFound();
            }
            return player;
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<Player>> Post([FromBody] string email)
        {
            if (emailValid(email))
            {
                Player newPlayer = new Player
                {
                    Email = email,
                    UserName = email,
                };

                await userManager.CreateAsync(newPlayer, "Pa$$w0rd");
                await _context.SaveChangesAsync();

                return newPlayer;
            }
            else
            {
                ModelState.AddModelError("Email", "Ongeldig email formaat.");
                return BadRequest(ModelState);
            }                       
        }

        // Valideren of het ingevoerde emailadres van het juiste formaat is.
        private bool emailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Emailadres wijzigen
        // PUT api/<UsersController>/5
        [HttpPut("{email}")]
        public async Task<ActionResult<Player>> Put(string email, [FromBody] string newEmail)
        {
            Player player = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (player == null)
            {
                return NotFound();
            }

            if (emailValid(newEmail))
            {
                player.Email = newEmail;
                player.UserName = newEmail;
                player.NormalizedEmail = newEmail.ToUpper();
                player.NormalizedUserName = newEmail.ToUpper();
                _context.Update(player);
                await _context.SaveChangesAsync();

                return player;
            }
            else
            {
                ModelState.AddModelError("Email", "Ongeldig email formaat.");
                return BadRequest(ModelState);
            }            
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{email}")]
        public async Task<ActionResult<Player>> Delete(string email)
        {
            Player player = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (player == null)
            {
                return NotFound();
            }

            _context.Remove(player);
            await _context.SaveChangesAsync();

            Player deletedPlayer = await _context.Users.FirstOrDefaultAsync(p => p.Email == email);
            if (deletedPlayer == null)
            {
                return Ok();
            }

            else
            {
                return BadRequest();
            }

        }
    }
}
