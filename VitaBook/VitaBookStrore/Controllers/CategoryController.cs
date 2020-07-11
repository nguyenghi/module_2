using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.Models;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private IGenreRepository genreRepository;
        public CategoryController(
                              IGenreRepository genreRepository,
                              IWebHostEnvironment webHostEnvironment)
        {

            this.webHostEnvironment = webHostEnvironment;
            this.genreRepository = genreRepository;

        }
        public IActionResult Index()
        {

            return View(genreRepository.Gets());

        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryViewModel genre)
        {
            if (ModelState.IsValid)
            {
                var Genre = new Genre()
                {
                    GenreName = genre.GenreName
                };
                var newGenre = genreRepository.Create(Genre);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ViewResult Edit(int id)
        {
            var genre = genreRepository.Get(id);
            if (genre == null)
            {
                return View("~/View/Error", id);
            }
            var genreEdit = new CategoryViewModel()
            {
                GenreId = genre.GenreId,
                GenreName = genre.GenreName
            };
            return View(genreEdit);

        }
        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                var newGenre = new Genre()
                {
                    GenreId= genre.GenreId,
                    GenreName = genre.GenreName
                };


                if (genreRepository.Edit(newGenre) != null)
                {
                    return RedirectToAction("Index");
                }

            }
            return View();
        }
              [HttpPost]

        public IActionResult Delete(int id)
        {
            if (genreRepository.Delete(id))
                return RedirectToAction("Index");
            return View();
        }
    }
}
     