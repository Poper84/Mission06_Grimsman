using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission_6.Models;
using System.Diagnostics;
// Here is all my controllers for my views each one either is a get or Post Method
namespace Mission_6.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext temp)
        {
            _context = temp;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {

            return View("AddMovie", new Movie());
        }
        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            if (ModelState.IsValid)
            {
            _context.Movies.Add(response);
                    _context.SaveChanges();
                    return View();
            }
            else 
            {
            return View(response);
            }
        }
        [HttpGet]
        public IActionResult Waitlist()
        {
            var Movies = _context.Movies
                .OrderBy(x => x.MovieId).ToList();

            return View(Movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var recordtoedit = _context.Movies
                .Single(x => x.MovieId == id);
            return View("AddMovie", recordtoedit);
        }

        [HttpPost]

        public IActionResult Edit(Movie updatedinfo)
        {
            _context.Update(updatedinfo);
            _context.SaveChanges();

            return RedirectToAction("Waitlist");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordtodelete = _context.Movies
                .Single(x => x.MovieId == id);
            return View(recordtodelete);
        }

        [HttpPost]

        public IActionResult Delete(Movie application)
        {
            _context.Movies.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("Waitlist");
        }

    }
}
