using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Models
{
   public interface IBookRepository
    {
        IEnumerable<Book> Gets();
        BookDetailViewModel Get(int id);
        Book Create(Book book);
        Book Edit(Book book);
        bool Delete(int id);
    }
}
