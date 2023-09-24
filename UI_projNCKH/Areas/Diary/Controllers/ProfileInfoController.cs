using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Areas.Diary.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Areas.Diary.Controllers
{
    [Area("Diary")]
    public class ProfileInfoController : Controller
    {
        private readonly ILogger<ProfileInfoController> _logger;

        public ProfileInfoController(ILogger<ProfileInfoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}