using CTFTournamentPlanner.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace CTFTournamentPlanner.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<Player> userManager;
        private IPasswordHasher<Player> passwordHasher;
        public AdminController(UserManager<Player> userManager)
        {
            this.userManager = userManager;
        }

        [Authorize(Roles = "Administrators")]
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        [Authorize(Roles = "Administrators")]
        public async Task<IActionResult> Edit(string id)
        {
            Player player = await userManager.FindByIdAsync(id);
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
    }
}
