using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Controllers
{
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