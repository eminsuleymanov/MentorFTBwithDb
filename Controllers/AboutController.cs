using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack2.DataAccessLayer;
using FrontToBack2.Models;
using Microsoft.AspNetCore.Mvc;


namespace FrontToBack2.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<About> abouts1 = _context.abouts.ToList();
            List<StaffQuotes> quotes1 = _context.quotes.ToList();
            ViewModels modell = new ViewModels {abouts=abouts1,quotes=quotes1 };
            //List<About> about = _context.abouts.ToList();
            return View(modell);
        }
    }
}

