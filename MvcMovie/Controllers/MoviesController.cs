using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MvcMovieContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;

        public MoviesController(MvcMovieContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string movieGenre, string searchString, string sortByDate)
        {
            // Use LINQ to get list of genres.
            ViewData["SortDate"] = string.IsNullOrEmpty(sortByDate) ? "SortDate" : "";
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                         select m;

            switch (sortByDate)
            {
                case "SortDate":
                    movies = movies.OrderBy(m => m.ReleaseDate);
                    break;

                default:
                    movies = movies.OrderByDescending(m => m.ReleaseDate);
                    break;
            }


            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var movieGenreVM = new MovieGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };

            return View(movieGenreVM);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Rating,Image")] MovieCreateModel movie)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                if (movie.Image != null)
                {
                    // ;
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + movie.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    movie.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Movie newMovie = new Movie
                {
                    Title = movie.Title,
                    ReleaseDate = movie.ReleaseDate,
                    Genre = movie.Genre,
                    Price = movie.Price,
                    Rating = movie.Rating,
                    Image = uniqueFileName
                };
                _context.Add(newMovie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            MovieEditModel newMovie = new MovieEditModel
            {
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Genre = movie.Genre,
                Price = movie.Price,
                Rating = movie.Rating,
                ImagePath = movie.Image,
                Image = null
            };
            return View(newMovie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price,Rating,Image,ImagePath")] MovieEditModel movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = movie.ImagePath;

                    if (movie.Image != null)
                    {
                        // ;
                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + movie.Image.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        movie.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                    }

                    Movie newMovie = new Movie
                    {
                        Id = id,
                        Title = movie.Title,
                        ReleaseDate = movie.ReleaseDate,
                        Genre = movie.Genre,
                        Price = movie.Price,
                        Rating = movie.Rating,
                        Image = uniqueFileName
                    };
                    _context.Update(newMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
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
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
