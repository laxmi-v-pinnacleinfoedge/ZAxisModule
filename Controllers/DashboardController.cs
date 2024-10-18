using Microsoft.AspNetCore.Mvc;
using ZAxisModule.ModelVM;

namespace ZAxisModule.Controllers
{

    public class DashboardController : Controller
    {
        private readonly Extension _session;
        SessionValues sessionValues = new SessionValues();
        public DashboardController(Extension session)
        {
            _session = session;
        }
        public IActionResult Dashboard()
        {
            var username = _session.GetSessionValue(sessionValues.UserName);
            ViewBag.UserName = username;
            return View();
        }
    }
}
