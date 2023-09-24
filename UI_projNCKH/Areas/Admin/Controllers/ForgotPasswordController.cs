using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Areas.Admin.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Areas.Admin.Controllers
{
    [Area("Admin")]
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