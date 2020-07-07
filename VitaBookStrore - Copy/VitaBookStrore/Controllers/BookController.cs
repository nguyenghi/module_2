using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.Models;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Controllers
{
    public class BookController: Controller
    {
        private IBookRepository bookRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private IGenreRepository genreRepository;



        public BookController(IBookRepository bookRepository,
                              IGenreRepository genreRepository,
                              IWebHostEnvironment webHostEnvironment)
        {
            this.bookRepository = bookRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.genreRepository = genreRepository;
            
        }
        public ViewResult DetailBook(int id)
        {
           
            var detailViewModel = new HomeDetailViewModel()
            {
                book = bookRepository.Get(id)
            };
            return View(detailViewModel);

        }

        [HttpGet]
        public ViewResult CreateBook()
        {
            ViewBag.Genre = GernesGets();
            return View();
        }
        [HttpPost]
        public IActionResult CreateBook(BookCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = new Book()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Author = model.Author,
                    Depscrip = model.Depscrip,
                    GenreId = model.GenreId,
                    Remain = model.Remain,


                };
                var fileName = string.Empty;
                if (model.AvatarPath != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_ {model.AvatarPath.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.AvatarPath.CopyTo(fs);
                    };
                }
                book.AvatarPath = fileName;
                var newBook = bookRepository.Create(book);
                return RedirectToAction("BookManagement", new { id = newBook.Id });


            }
            return View();

        }
        public ViewResult EditBook(int id)
        
        {
            var book = bookRepository.Get(id);
            var editBook = new BookEditViewModel()
            {
                Name = book.Name,
                Price = book.Price,
                Author = book.Author,
                Depscrip = book.Depscrip,
                GenreId = book.GenreId,
                Remain = book.Remain,

              
            };
            return View(editBook);
        }
        [HttpPost]
        public IActionResult EditBook(BookEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = new Book()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Author = model.Author,
                    Depscrip = model.Depscrip,
                    GenreId = model.GenreId,
                    Remain = model.Remain,
                    Id = model.Id

                };
                var fileName = string.Empty;
                if (model.AvatarPath != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_ {model.AvatarPath.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.AvatarPath.CopyTo(fs);
                    };
                    book.AvatarPath = fileName;
                    if (!string.IsNullOrEmpty(model.Avatar))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath,
                                    "images", model.Avatar);
                        System.IO.File.Delete(delFile);

                    }
                }
                var editBook = bookRepository.Edit(book);

                if (editBook != null)
                {
                    return RedirectToAction("BookManagement", new { id = book.Id });
                }
            }
            return View();
        
        }
        public IActionResult BookManagement()
        {
            ViewBag.Books = bookRepository.Gets();
            return View();
        }
        public IActionResult Delete(int id)
        {
            bookRepository.Delete(id);
            return RedirectToAction("BookManagement");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private List<Genre> GernesGets()
        {
            return genreRepository.Gets().ToList();
        }
    }
}
