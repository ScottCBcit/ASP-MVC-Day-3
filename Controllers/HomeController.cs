using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppIdentity1.Data;
using WebAppIdentity1.Models;

namespace WebAppIdentity1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize]
        public IActionResult SecureArea()
        {
            // Get user name of user who is logged in.
            // This line must be in the controller.
            string userName = User.Identity.Name;

            // Usually this section would be in a repository.
            var registeredUser = _context.MyRegisteredUsers
                                         .Where(ru => ru.Email == userName)
                                         .FirstOrDefault();

            return View(registeredUser);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}