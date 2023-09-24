using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_projNCKH.Areas.Diary.Models;
using UI_projNCKH.Services;

namespace UI_projNCKH.Areas.Diary.Controllers
{
    [Area("Diary")]
    public class PostDiaryController : Controller
    {
        private readonly ILogger<PostDiaryController> _logger;

        public PostDiaryController(ILogger<PostDiaryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}