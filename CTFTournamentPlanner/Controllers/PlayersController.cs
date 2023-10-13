using CTFTournamentPlanner.Data;
using CTFTournamentPlanner.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace CTFTournamentPlanner.Controllers
{
    public class PlayersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Player> userManager;
        private IPasswordHasher<Player> passwordHasher;
        public PlayersController(ApplicationDbContext context, UserManager<Player> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        [Authorize(Roles = "Administrators")]
        public IActionResult Index()
        {
            var viewModel = new TeamIndexViewModel
            {
                Teams = _context.Teams.Include(t => t.Players).ToList(),
                Players = _context.Users.Include(p => p.Team).ToList()
            };
            // return View(userManager.Users);
            return View(viewModel);
        }
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            Player player = _context.Users
                .Include(p => p.Team)
                .FirstOrDefault(p => p.Id == id);

            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            Player player = await userManager.FindByIdAsync(id);
            Player currentUser = await userManager.GetUserAsync(User);
            if (currentUser.Id != player.Id)
            {
                ModelState.AddModelError("", "Je mag alleen je eigen gegevens wijzigen!"); 
            }

            if (player != null)
                return View(player);
            else
                return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrators")]
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, string username)
        {
            Player player = await userManager.FindByIdAsync(id);
            if (player != null)
            {
                // if (!string.IsNullOrEmpty(email))                   
                player.Email = email;

                /* 
                else
                    ModelState.AddModelError("", "Email cannot be empty");
                */

                // if (!string.IsNullOrEmpty(username))               
                player.UserName = username;
                
                /*
                else
                    ModelState.AddModelError("", "Username cannot be empty");
                */

                // if (!string.IsNullOrEmpty(password))
                // player.PasswordHash = passwordHasher.HashPassword(player, password);
                
                /*
                else
                    ModelState.AddModelError("", "Password cannot be empty");
                */

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(username))
                {
                    IdentityResult result = await userManager.UpdateAsync(player);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(player);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
   
        [Authorize (Roles = "Administrators")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || userManager.Users == null)
            {
                return NotFound();
            }

            Player player = await userManager.FindByIdAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            return View("Delete", player);
        }

        [Authorize (Roles = "Administrators")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Player player = await userManager.FindByIdAsync(id);
            if (userManager.Users == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Teams'  is null.");
            }

            if (player != null)
            {

                // Als de gebruiker in een team zit, en hij het enig teamlid is of een teamleider is,
                // wordt zijn team ook verwijderd.
                Team? playerTeam = await _context.Teams.FindAsync(player.TeamId);
                Console.WriteLine(playerTeam);

                // Requirement om het teamleiderschap aan een ander teamlid te geven
                // kan hier geïmplementeerd worden.
                // List<Player> TeamMembers = userManager.Users.Where(p => p.TeamId == playerTeam.Id).ToList();
                // ...
                if (playerTeam != null && player.IsTeamLeader == true)
                {
                    _context.Teams.Remove(playerTeam);
                    await _context.SaveChangesAsync();
                }

                IdentityResult result = await userManager.DeleteAsync(player);
                if (result.Succeeded)
                                                                     
                    return RedirectToAction(nameof(Index));
                
                else
                    Errors(result);               
            }
            return View("Index", userManager.Users);
        }
    }
}
