using F1App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formula.Controllers
{
    public class TrkeController : Controller
    {
        private readonly DataContext _context;


        public TrkeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var trke = _context.Trke.Include(s => s.Staza).ToList();
            return View(trke);
        }
    }
}
