using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Areas.Admin.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Areas.Admin.Controllers
{
    [Area("Admin")]
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