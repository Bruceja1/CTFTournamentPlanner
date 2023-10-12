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

        private bool BracketExists(int id)
        {
          return (_context.Brackets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
