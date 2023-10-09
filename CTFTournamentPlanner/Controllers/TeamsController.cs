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
            var viewModel = new TeamIndexViewModel
            {
                Teams = _context.Teams.Include(t => t.Players).ToList(),
                Players = _context.Users.ToList()
            };

            if (_context.Teams == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Teams'  is null.");
            }

            return View(viewModel);           
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
        public async Task <IActionResult> Create()
        {
            Player currentUser = await userManager.GetUserAsync(User);
            string currentUserId = await userManager.GetUserIdAsync(currentUser);


            bool userHasTeam = _context.Users.Any(p => p.Id == currentUserId && p.TeamId != null);
            if (userHasTeam)
            {
                ModelState.AddModelError(string.Empty, "Om een nieuw team aan te maken moet je eerst je huidige team verlaten.");
            }
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
            
            
            bool userHasTeam = _context.Users.Any(p => p.Id == currentUserId && p.TeamId != null);
            if (userHasTeam)
            {
                ModelState.AddModelError(string.Empty, "Om een nieuw team aan te maken moet je eerst je huidige team verlaten.");
            }
            
            
            if (ModelState.IsValid)
            {
                // Check of een team met de door de gebruiker ingevoerde naam al bestaat.
                var existingTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Name == team.Name);
                if (existingTeam != null)
                {                  
                    ModelState.AddModelError(string.Empty, "Dit team bestaat al.");                    
                }

                // Huidige gebruiker toevoegen aan het team.
                currentUser.Team = team;
                currentUser.IsTeamLeader = true;
                               
                _context.Add(team);                             
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
        [Authorize]
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

            Player currentUser = await userManager.GetUserAsync(User);
            if (currentUser.IsTeamLeader == false | currentUser.Team != team)
            {
                ModelState.AddModelError("", "Je mag alleen je eigen team verwijderen.");
                return View("Delete", team);
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [Authorize]
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
            if (currentUser.IsTeamLeader == false | currentUser.Team != team)
            {              
                ModelState.AddModelError("", "Je mag alleen je eigen team verwijderen.");
                return View("Delete", team);
            }

            if (team == null)
            {
                ModelState.AddModelError("", "Team not found");
                return RedirectToAction(nameof(Index));
            }

            else
            {
                _context.Teams.Remove(team);
                await _context.SaveChangesAsync();
            }
                                 
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return (_context.Teams?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
