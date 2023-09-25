using Microsoft.AspNetCore.Mvc;

namespace UI_projNCKH.Areas.Account.Controllers
{
    [Area("Account")]
    public class ForgotPasswordController : Controller
    {
        private readonly ILogger<ForgotPasswordController> _logger;

        public ForgotPasswordController(ILogger<ForgotPasswordController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}