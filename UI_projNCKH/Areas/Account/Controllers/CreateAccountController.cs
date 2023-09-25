using Microsoft.AspNetCore.Mvc;

namespace UI_projNCKH.Areas.Account.Controllers
{
    [Area("Account")]
    public class CreateAccountController : Controller
    {
        private readonly ILogger<CreateAccountController> _logger;

        public CreateAccountController(ILogger<CreateAccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}