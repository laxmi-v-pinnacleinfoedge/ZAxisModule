using Microsoft.AspNetCore.Mvc;
using ZAxisModule.ModelVM;
using ZAxisModule.Repositories.abstractrepositories;

namespace ZAxisModule.Controllers
{
    public class HomeController : Controller
    {
        ILogin _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ILogin db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public IActionResult Login(LoginVM loginVM)
        {
            _db.IsValid(loginVM);
            return RedirectToAction("Dashboard", "Dashboard");
        }
        [HttpPost]
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}