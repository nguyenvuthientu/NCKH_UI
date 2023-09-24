using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Areas.Diary.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Areas.Diary.Controllers
{
    [Area("Diary")]
    public class ProfileDiaryController : Controller
    {
        private readonly ILogger<ProfileDiaryController> _logger;

        public ProfileDiaryController(ILogger<ProfileDiaryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}