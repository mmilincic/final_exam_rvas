using F1App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formula.Controllers
{
    public class VozaciController : Controller
    {

        private readonly DataContext _context;

        public VozaciController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var vozaci = _context.Vozaci.Include(v => v.Tim).ToList();
            return View(vozaci);
        }
    }
}
