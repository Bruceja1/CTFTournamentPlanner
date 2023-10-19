using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CTFTournamentPlanner.Data;
using CTFTournamentPlanner.Models;

namespace CTFTournamentPlanner.Controllers
{
    public class MatchupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatchupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Matchups
        public async Task<IActionResult> Index()
        {
              return _context.Matchups != null ? 
                          View(await _context.Matchups.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Matchups'  is null.");
        }

        // Matchup details zijn te zien in de bracket details.
        // GET: Matchups/Details/5
        /*
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Matchups == null)
            {
                return NotFound();
            }

            var matchup = await _context.Matchups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchup == null)
            {
                return NotFound();
            }

            return View(matchup);
        }
        */

        // Matchups worden automatisch aangemaakt wanneer een bracket gegenereerd wordt.
        // GET: Matchups/Create
        /*
        public IActionResult Create()
        {
            return View();
        }
        */

        // Matchups worden automatisch aangemaakt wanneer een bracket gegenereerd wordt.

        // POST: Matchups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ScoreA,ScoreB,RoundId")] Matchup matchup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchup);
        }

        */

        // GET: Matchups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Matchups == null)
            {
                return NotFound();
            }

            Matchup matchup = await _context.Matchups
                .Include(m => m.Teams)
                .Include(m => m.Round)
                    .ThenInclude(r => r.Bracket)
                        .ThenInclude(b => b.Teams)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (matchup == null)
            {
                return NotFound();
            }
            return View(matchup);
        }
        

        // POST: Matchups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int selectedTeam1, int selectedTeam2, [Bind("Id,ScoreA,ScoreB,RoundId")] Matchup matchup)
        {
            if (id != matchup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    _context.Update(matchup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchupExists(matchup.Id))
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
            return View(matchup);
        }

        // Matchups worden verwijderd wanneer de bracket verwijderd wordt.

        // GET: Matchups/Delete/5
        /*
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Matchups == null)
            {
                return NotFound();
            }

            var matchup = await _context.Matchups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchup == null)
            {
                return NotFound();
            }

            return View(matchup);
        }

        // POST: Matchups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Matchups == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Matchups'  is null.");
            }
            var matchup = await _context.Matchups.FindAsync(id);
            if (matchup != null)
            {
                _context.Matchups.Remove(matchup);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */
        private bool MatchupExists(int id)
        {
          return (_context.Matchups?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        
    }
}
