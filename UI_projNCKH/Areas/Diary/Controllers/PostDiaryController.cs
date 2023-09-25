using Microsoft.AspNetCore.Mvc;

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