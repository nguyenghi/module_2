using Microsoft.AspNetCore.Authorization;
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


        private readonly AppDbContext context;
        
        public BookController(IBookRepository bookRepository,
                              IGenreRepository genreRepository,
                              IWebHostEnvironment webHostEnvironment, 
                              AppDbContext context)
        {
            this.bookRepository = bookRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.genreRepository = genreRepository;
            this.context = context;


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
        [Authorize]
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

        [HttpGet]
        [Authorize]
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
                AvtPath = book.AvatarPath
              
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
                    Id= model.Id

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
                    if (!string.IsNullOrEmpty(model.AvtPath))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath,
                                    "images", model.AvtPath);
                        System.IO.File.Delete(delFile);

                    }
                }
                else
                {
                    book.AvatarPath = model.AvtPath;
                }
                 bookRepository.Edit(book);
                    return RedirectToAction("BookManagement", new { id = book.Id });
              
            }
            return View();

        }
        [Authorize]
        public IActionResult BookManagement()
        {
            ViewBag.Books = bookRepository.Gets();
            return View();
        }
        [Authorize]
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
