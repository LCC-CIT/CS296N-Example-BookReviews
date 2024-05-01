using Microsoft.AspNetCore.Mvc;

// Pre-built controller
namespace BookReviews.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
