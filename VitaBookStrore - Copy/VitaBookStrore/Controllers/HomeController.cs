using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VitaBookStrore.Models;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Controllers
{
    public class HomeController : Controller
    {
        private  IBookRepository bookRepository;
        private readonly IWebHostEnvironment webHostEnvironment;



        public HomeController (IBookRepository bookRepository,
                                IWebHostEnvironment webHostEnvironment)
        {
            this.bookRepository = bookRepository;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()

        {
            var indexViewModel = new HomeIndexViewModel()
            {
                Books = bookRepository.Gets()
               
            };
            return View(indexViewModel);
            
        }
        public ViewResult Detail(int id)
        {
        
            var detailViewModel = new HomeDetailViewModel()
            {
                book = bookRepository.Get(id)
            };
            return View(detailViewModel);

        }
       
        public IActionResult BookManagement()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
