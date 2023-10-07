using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTFTournamentPlanner.Data;
using CTFTournamentPlanner.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CTFTournamentPlanner.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Player> userManager;

        public TeamsController(ApplicationDbContext context, UserManager<Player> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        // GET: Teams      
        public async Task<IActionResult> Index()
        {
            return _context.Teams != null ?
                        View(await _context.Teams.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Teams'  is null.");
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Teams == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }


        // GET: Teams/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Team team)
        {
            Player currentUser = await userManager.GetUserAsync(User);
            string currentUserId = await userManager.GetUserIdAsync(currentUser);
            

            if (currentUser.PlayerTeamId != null)
            {
                // Als een gebruiker al lid is van een team, mag deze geen nieuw team aanmaken.
                ModelState.AddModelError(string.Empty, "You must first leave your current team before creating a new one.");
            }
            
            if (ModelState.IsValid)
            {
                // Check of een team met de door de gebruiker ingevoerde naam al bestaat.
                var existingTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Name == team.Name);
                if (existingTeam != null)
                {                  
                    ModelState.AddModelError(string.Empty, "A team with this name already exists.");                    
                }

                
                // Huidige gebruiker toevoegen aan het team. (ICollection<CTFTournamentPlannerUser>)               
                team.Players.Add(currentUser);
                
                team.TeamLeader = currentUser;
                team.TeamLeaderId = currentUserId;
                
                _context.Add(team);
                
                // Vanaf hier wordt team.Id pas definitief. Daarna kan de waarde van team.Id pas toegekend worden aan PlayerTeamId.
                await _context.SaveChangesAsync();
                currentUser.PlayerTeamId = team.Id;
                currentUser.Team = team;

                string currentUserTeam = currentUser.Team.Name;
                Console.WriteLine(currentUserTeam);

                // Even controleren of het mogelijk is om alle spelernamen uit een team op te halen.
                foreach (Player p in team.Players)
                {
                    Console.WriteLine(p.UserName);
                }

                // Vandaar dat hier een tweede SaveChangesAsync() uitgevoerd moet worden; om currentUser.UserTeamId op te slaan!
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }


        // GET: Teams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Teams == null)
            {
                return NotFound();
            }

            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Teamleader, Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(team);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(team.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }


        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Teams == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Player currentUser = await userManager.GetUserAsync(User);
           
            if (_context.Teams == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Teams'  is null.");
            }

            Team team = await _context.Teams.FindAsync(id);
            if (currentUser.Id != team.TeamLeaderId)
            {
                /* ModelState.AddModelError(string.Empty, "You may only remove a team that you own."); */
                ModelState.AddModelError(string.Empty, "You may only remove a team that you own.");
            }

            if (team != null)
            {
                _context.Teams.Remove(team);

                foreach (Player Player in team.Players)
                {
                    Player.PlayerTeamId = null;
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return (_context.Teams?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
