using F1App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Formula.Models;

namespace Formula.Controllers
{
    public class TimKontroler : Controller
    {
        private readonly DataContext _context; // privatno readonly polje

        // konstruktor – DI ubacuje context
        public TimKontroler(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Učitavanje timova zajedno sa vozačima
            var timovi = _context.Staze;
            return View(timovi);
        }
    }
}
