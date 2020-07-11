using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public  string Author  { get; set; }
        public string AvatarPath { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
      
        public string Depscrip { get; set; }
        public int Remain { get; set; }
        public string Category { get; set; }


    }
}
