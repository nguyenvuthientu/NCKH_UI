using Microsoft.AspNetCore.Mvc;

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