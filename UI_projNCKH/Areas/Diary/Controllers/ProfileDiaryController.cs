using Microsoft.AspNetCore.Mvc;

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