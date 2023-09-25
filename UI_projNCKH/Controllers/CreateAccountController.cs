using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Controllers
{
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