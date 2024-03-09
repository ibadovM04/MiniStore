using Microsoft.AspNetCore.Mvc;
using MiniStore.Data;

namespace MiniStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public HomeController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
