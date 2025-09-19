using F1App.Data;
using Formula.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formula.Controllers
{
    public class StazeController : Controller
    {
        private readonly DataContext _context;

        public StazeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var staze = _context.Staze.ToList();
            return View(staze);
        }

        public IActionResult Create([Bind("nazivStaze,duzina")] Staza staza)
        {
            if (ModelState.IsValid)
            {
                _context.Staze.Add(staza);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staza);
        }
        
        public IActionResult Delete(int? id)
        {
            var staza = _context.Staze.Find(id);
            if (staza == null)
            {
                return NotFound();
            }

            _context.Staze.Remove(staza);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staza = _context.Staze.Find(id);

            if (staza == null)
            {
                return NotFound();
            }

            return View(staza);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("StazaID, nazivStaze, duzina")] Staza staza)
        {
            
            if (id != staza.stazaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staza);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Staze.Any(e => e.stazaId == staza.stazaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
                return RedirectToAction(nameof(Index));
            }

            return View(staza);
        }
    }
}
