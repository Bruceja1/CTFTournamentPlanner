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
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CTFTournamentPlanner.Controllers
{
    public class BracketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Player> userManager;

        // Voor het verwisselen van de volgorde van de teams (zie GenerateBracket(); hieronder).
        private static Random rng = new Random();

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

            Bracket bracket = await _context.Brackets
                .Include(b => b.Teams)
                .Include(b => b.Rounds)
                    .ThenInclude(r => r.Matchups)
                        .ThenInclude(m => m.Teams)
                .FirstOrDefaultAsync(b => b.Id == id);
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
                bracket.Teams = new List<Team>();

                List<Team> teams = await _context.Teams.ToListAsync();
                foreach (Team team in teams)
                {
                    bracket.Teams.Add(team);
                }

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

            var bracket = await _context.Brackets
                .Include(b => b.Teams)
                .Include(b => b.Rounds)
                    .ThenInclude(r => r.Matchups)
                        .ThenInclude(m => m.Teams)
                .FirstOrDefaultAsync(b => b.Id == id);
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
                // Alle rondes van een bracket worden opgehaald en verwijderd.
                List<Round> rounds = _context.Rounds.Where(r => r.BracketId == bracket.Id).ToList();
                
                foreach (Round round in rounds)
                {   
                    // Alle matchups van een ronde worden opgehaald en verwijderd.
                    List<Matchup> matchups = _context.Matchups.Where(m => m.RoundId == round.Id).ToList();
                    foreach (Matchup matchup in matchups)
                    {
                        _context.Matchups.Remove(matchup);
                    }
                    _context.Rounds.Remove(round);
                }
                _context.Brackets.Remove(bracket);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Aangezien het niet praktisch is om elk team individueel aan te moeten melden om deel te nemen aan een bracket, is deze
        // functionaliteit voor deze inleveropdracht eruit gehaald.
        /*
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
        */

        [Authorize (Roles = "Administrators")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GenerateBracket(int id)
        {
            // Scenario waarin het aantal teams oneven is verwerken...

            Bracket bracket = await _context.Brackets
                .Include(b => b.Teams)
                .Include(b => b.Rounds)
                    .ThenInclude(r => r.Matchups)
                        .ThenInclude(m => m.Teams)
                .FirstOrDefaultAsync(b => b.Id == id);

            
            List<Team> teams = bracket.Teams.ToList();           

            if (bracket == null | bracket.Teams == null)
            {
                return NotFound();
            }

            if (bracket.IsGenerated == true)
            {
                ModelState.AddModelError("", "Deze bracket is al gegenereerd.");
            }

            if (bracket.IsActive == false)
            {
                ModelState.AddModelError("", "Deze bracket is niet meer actief.");
                return View("Details", id);
            }

            if (teams.Count() < 4)
            {
                ModelState.AddModelError("", "Er moeten minimaal vier teams aangemeld zijn voor het toernament.");
            }

            if (teams.Count() / 4 != 0)
            {
                ModelState.AddModelError("", "Het aantal teams moet deelbaar zijn door vier.");
            }

            // Volgorde teams verwisselen met de Fisher-Yates shuffle zodat teams willekeurig ingedeeld kunnen worden.
            int n = teams.Count();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Team value = teams[k];
                teams[k] = teams[n];
                teams[n] = value;
            }

            // Stel: Teams.Count = 8. 2^n = 8 -> n = 3 dus aantal rondes = log2(8).
            // Stel: Teams.Count = 6. log2(6) = 2,584..., dus naar boven afronden.
            int roundCount = (int)Math.Ceiling(Math.Log2(bracket.Teams.Count));
            // double roundCount = Math.Ceiling(Math.Log2(bracket.Teams.Count));

            // double i = teams.Count();
            int i = teams.Count();
            for (int h = 1; h <= roundCount; h++)
            {
                Round round = new Round();
                round.BracketId = bracket.Id;

                if (h == roundCount)
                {
                    round.Name = "Finale";
                }

                else if (h == roundCount - 1)
                {
                    round.Name = "Halve Finale";
                }

                else
                {
                    round.Name = $"Ronde {h}";
                }

                _context.Rounds.Add(round);
                await _context.SaveChangesAsync();
                

                // 'j' representeert het aantal matchups in de ronde, dus het aantal teams gedeeld door twee.
                // Stel dat het aantal teams in een ronde oneven is; het alleenstaande team wordt dan doorgeschoven naar de volgende
                // ronde. Dus aantal matchups naar beneden afronden.
                // for (double j = Math.Floor((double)i / 2); j > 0; j--)
                for (int j = i / 2; j > 0; j--)
                {
                    Matchup matchup = new Matchup();
                    matchup.Teams = new List<Team>();
                    matchup.RoundId = round.Id;

                    // In de eerste ronde wordt elk team willekeurig ingedeeld.
                    if (i == bracket.Teams.ToList().Count())
                    {
                        matchup.Teams.Add(teams[teams.Count() - 1]);
                        teams.RemoveAt(teams.Count() - 1);
                        matchup.Teams.Add(teams[teams.Count() - 1]);
                        teams.RemoveAt(teams.Count() - 1);

                    }
                    _context.Matchups.Add(matchup);
                    await _context.SaveChangesAsync();
                }
                i /= 2;
                // i = Math.Floor(i / 2);
            }
                    
            bracket.IsGenerated = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details), bracket);

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
