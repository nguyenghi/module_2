using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.Models;

namespace VitaBookStrore.ViewModels
{
    public class CategoryViewModel
    {
        [Required]
        public int GenreId { get; set; }
        [Required]
        [MaxLength(100)]
        public string GenreName { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
