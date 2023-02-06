using FrontToBack2.DataAccessLayer;
using FrontToBack2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Course> courses = _context.courses.ToList();
            return View(courses);
        }
    }
}
