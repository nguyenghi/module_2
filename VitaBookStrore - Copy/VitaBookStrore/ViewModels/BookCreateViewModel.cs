using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.Models;

namespace VitaBookStrore.ViewModels
{
    public class BookCreateViewModel
    {

        public int Id { get; set; }
       
        public string Name { get; set; }
      
        public int Price { get; set; }
       
        public string Author { get; set; }
        public IFormFile AvatarPath { get; set; }
        public int GenreId { get; set; }
        public Genre GenreName { get; set; }
        public string Depscrip { get; set; }
        public int Remain { get; set; }
        public string Category { get; set; }

    }
}
