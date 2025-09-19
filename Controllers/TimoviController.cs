using F1App.Data;
using Microsoft.AspNetCore.Mvc;

namespace Formula.Controllers
{
    public class TimoviController : Controller
    {
        private readonly DataContext _context;

        public TimoviController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var timovi = _context.Timovi.ToList();
            return View(timovi);
        }
    }
}
