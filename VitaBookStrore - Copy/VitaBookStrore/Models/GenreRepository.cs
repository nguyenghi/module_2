using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.Models
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext context;
        public GenreRepository(AppDbContext context)
        {
            this.context = context;

        }
        public IEnumerable<Genre> Gets()
        {
            return context.Genres;
        }
    }
}
