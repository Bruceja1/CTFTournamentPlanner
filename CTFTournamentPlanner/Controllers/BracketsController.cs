using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CTFTournamentPlanner.Data;
using CTFTournamentPlanner.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CTFTournamentPlanner.Controllers
{
    public class BracketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Player> userManager;

        public BracketsController(ApplicationDbContext context, UserManager<Player> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        // GET: Brackets
        public async Task<IActionResult> Index()
        {
              return _context.Brackets != null ? 
                          View(await _context.Brackets.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Brackets'  is null.");
        }

        // GET: Brackets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Brackets == null)
            {
                return NotFound();
            }

            var bracket = await _context.Brackets
                .Include(b => b.Teams)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bracket == null)
            {
                return NotFound();
            }

            return View(bracket);
        }

        [Authorize (Roles ="Administrators")]
        // GET: Brackets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brackets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize (Roles = "Administrators")]
        public async Task<IActionResult> Create([Bind("Id,Name")] Bracket bracket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bracket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bracket);
        }

        [Authorize(Roles = "Administrators")]
        // GET: Brackets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Brackets == null)
            {
                return NotFound();
            }

            var bracket = await _context.Brackets.FindAsync(id);
            if (bracket == null)
            {
                return NotFound();
            }
            return View(bracket);
        }

        // POST: Brackets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrators")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Bracket bracket)
        {
            if (id != bracket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bracket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BracketExists(bracket.Id))
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
            return View(bracket);
        }

        [Authorize(Roles = "Administrators")]
        // GET: Brackets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Brackets == null)
            {
                return NotFound();
            }

            var bracket = await _context.Brackets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bracket == null)
            {
                return NotFound();
            }

            return View(bracket);
        }

        // POST: Brackets/Delete/5
        [Authorize (Roles = "Administrators")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Brackets == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Brackets'  is null.");
            }
            var bracket = await _context.Brackets.FindAsync(id);
            if (bracket != null)
            {
                _context.Brackets.Remove(bracket);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> SignUp(int id)
        {
            Bracket bracket = await _context.Brackets
                .Include(b => b.Teams)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (bracket.IsActive == false)
            {
                ModelState.AddModelError("", "Deze bracket is niet meer actief.");
                return View("Details", id);
            }

            Player currentUser = await userManager.GetUserAsync(User);
            Team currentUserTeam = await _context.Teams.FirstOrDefaultAsync(t => t.Id == currentUser.TeamId);
                                
            if (currentUser.IsTeamLeader == false || currentUser.TeamId == null)
            {
                ModelState.AddModelError("", "Alleen teamleiders kunnen hun team aanmelden voor een toernament.");
                return View(bracket);
            }

            if (bracket == null)
            {
                return NotFound();
            }

            bracket.Teams.Add(currentUserTeam);
            await _context.SaveChangesAsync();

            return View("Details", bracket);
        }
               
        public async Task<IActionResult> GenerateBracket(int id)
        {
            Bracket bracket = await _context.Brackets
                .Include(b => b.Teams)
                .FirstOrDefaultAsync(b => b.Id == id);

            List<Team> teams = bracket.Teams.ToList();

            if (bracket.IsActive == false)
            {
                ModelState.AddModelError("", "Deze bracket is niet meer actief.");
                return View("Details", id);
            }

            // Stel: Teams.Count = 8. 2^n = 8 -> n = 3 dus aantal rondes = log2(8).
            // Stel: Teams.Count = 6. log2(6) = 2,584..., dus naar boven afronden.
            double roundCount = Math.Ceiling(Math.Log2(bracket.Teams.Count));

            List<Round> rounds = new List<Round>();
            for (int i = 1; i <= roundCount; i++)
            {
                Round round = new Round();
                round.BracketId = bracket.Id;

                if (i == roundCount)
                {
                    round.Name = "Finale";
                }

                if (i == roundCount - 1)
                {
                    round.Name = "Halve Finale";
                }

                else
                    round.Name = $"Ronde {i}";

                rounds.Add(round);
                _context.Rounds.Add(round);
                await _context.SaveChangesAsync();
            }

            foreach (Round round in rounds)
            {
                Matchup matchup = new Matchup();

            }

            
            return View("Details", bracket);

        }

        public async Task<IActionResult> ArchiveBracket(int id)
        {
            Bracket bracket = await _context.Brackets
                .FirstOrDefaultAsync(b => b.Id == id);
 
            _context.Update(bracket.IsActive == false);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool BracketExists(int id)
        {
          return (_context.Brackets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
