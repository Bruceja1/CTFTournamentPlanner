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
            var applicationDbContext = _context.Matchups.Include(m => m.Round);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Matchups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Matchups == null)
            {
                return NotFound();
            }

            var matchup = await _context.Matchups
                .Include(m => m.Round)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchup == null)
            {
                return NotFound();
            }

            return View(matchup);
        }

        // GET: Matchups/Create
        public IActionResult Create()
        {
            ViewData["RoundId"] = new SelectList(_context.Rounds, "Id", "Id");
            return View();
        }

        // POST: Matchups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ScoreA,ScoreB,RoundId,SelectedTeamAId,SelectedTeamBId")] Matchup matchup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoundId"] = new SelectList(_context.Rounds, "Id", "Id", matchup.RoundId);
            return View(matchup);
        }

        // GET: Matchups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Matchups == null)
            {
                return NotFound();
            }

            var matchup = await _context.Matchups
                .Include(m => m.Teams)
                .Include(m => m.Round)
                    .ThenInclude(r => r.Bracket)
                        .ThenInclude(b => b.Teams)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchup == null)
            {
                return NotFound();
            }
            ViewData["RoundId"] = new SelectList(_context.Rounds, "Id", "Id", matchup.RoundId);
            return View(matchup);
        }

        // POST: Matchups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ScoreA,ScoreB,RoundId,SelectedTeamAId,SelectedTeamBId")] Matchup matchup)
        {
            if (id != matchup.Id)
            {
                return NotFound();
            }

            if (matchup.SelectedTeamAId == matchup.SelectedTeamBId)
            {
                ModelState.AddModelError("", "Een team mag niet twee keer voorkomen in een matchup.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Bestaande matchup ophalen.
                    var existingMatchup = await _context.Matchups
                        .Include(m => m.Teams)
                        .FirstOrDefaultAsync(m => m.Id == matchup.Id);

                    if (existingMatchup != null)
                    {
                        var teamA = await _context.Teams.FindAsync(matchup.SelectedTeamAId);
                        var teamB = await _context.Teams.FindAsync(matchup.SelectedTeamBId);

                        existingMatchup.Teams.Clear();
                        existingMatchup.Teams.Add(teamA);
                        existingMatchup.Teams.Add(teamB);

                        existingMatchup.ScoreA = matchup.ScoreA;
                        existingMatchup.ScoreB = matchup.ScoreB;

                        existingMatchup.SelectedTeamAId = matchup.SelectedTeamAId;
                        existingMatchup.SelectedTeamBId = matchup.SelectedTeamBId;

                        _context.Update(existingMatchup);
                        await _context.SaveChangesAsync();
                    }                                   
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
            ViewData["RoundId"] = new SelectList(_context.Rounds, "Id", "Id", matchup.RoundId);
            return View(matchup);
        }

        // GET: Matchups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Matchups == null)
            {
                return NotFound();
            }

            var matchup = await _context.Matchups
                .Include(m => m.Round)
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

        private bool MatchupExists(int id)
        {
          return (_context.Matchups?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
