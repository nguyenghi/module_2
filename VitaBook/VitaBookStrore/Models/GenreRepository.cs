using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Models
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext context;

        public GenreRepository(AppDbContext context)
        {
            this.context = context;

        }

        public Genre Create(Genre genre)
        {
            context.Genres.Add(genre);
            context.SaveChanges();
            return genre;
        }

        public bool Delete(int id)
        {
            var deleteGenre = context.Genres.Find(id);
            if (deleteGenre != null)
            {
                context.Genres.Remove(deleteGenre);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Genre Edit(Genre genre)
        {
            var editGenre = context.Genres.Attach(genre);
            editGenre.State = EntityState.Modified;
            context.SaveChanges();
            return genre;
        }

        public Genre Get(int id)
        {
            return context.Genres.Find(id);
        }

        public IEnumerable<Genre> Gets()
        {
            return context.Genres;
        }
       

    }
}
