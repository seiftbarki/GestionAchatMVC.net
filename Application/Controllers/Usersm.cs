using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Controllers
{
    public class Usersm : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public Usersm(UserManager<ApplicationUser> userManager)
        {
            _userManager= userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
    }
}
