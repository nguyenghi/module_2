using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.Models
{
    public class Genre
    {
        [Required]
        public int GenreId { get; set; }
        [Required]
        [MaxLength(100)]
        public string GenreName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
