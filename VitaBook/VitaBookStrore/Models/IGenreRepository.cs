using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Models
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> Gets();
        Genre Get(int id);
        Genre Create(Genre genre );
        Genre Edit(Genre genre);
        bool Delete(int id);
    }
}
