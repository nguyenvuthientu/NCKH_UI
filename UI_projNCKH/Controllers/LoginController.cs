using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}