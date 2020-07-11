using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VitaBookStrore.Models;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles =("Admin"))]
    public class HomeController : Controller
    {
        private  IBookRepository bookRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly AppDbContext context;
        public HomeController (IBookRepository bookRepository,
                                IWebHostEnvironment webHostEnvironment,
                                    AppDbContext context)
        {
            this.bookRepository = bookRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()

        {
            var indexViewModel = new HomeIndexViewModel()
            {
                Books = bookRepository.Gets()
               
            };
            return View(indexViewModel);
            
        }
        [AllowAnonymous]
        public ViewResult Detail(int id)
        {
        
            var detailViewModel = new HomeDetailViewModel()
            {
                book = bookRepository.Get(id)
            };
            return View(detailViewModel);

        }
        [Authorize]
        public IActionResult BookManagement()
        {
            return View();
        }
        public IActionResult Management()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult BookCategory(int id)
        {
            var data = (from b in context.Books
                        join g in context.Genres on b.GenreId equals g.GenreId
                        where b.GenreId == id
                        select new BookCategogyViewModel()
                        {
                            Id = b.Id,
                            Name = b.Name,
                            Author = b.Author,
                            Price = b.Price,
                            Depscrip = b.Depscrip,
                            GenreName = g.GenreName,
                            AvatarPath = b.AvatarPath

                        }).ToList();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
