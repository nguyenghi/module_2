using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.Models
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> Gets();
    }
}
