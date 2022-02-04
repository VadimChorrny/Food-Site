using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SushiSite.Models;

namespace SushiSite.Controllers
{
    [Authorize(Roles = "admin")]
    public class AccountController : Controller
    {
        //private readonly UserManager<User> _userManager;
        //private readonly SignInManager<User> _signInManager;
        public IActionResult Index()
        {
            return View();
        }
    }
}
