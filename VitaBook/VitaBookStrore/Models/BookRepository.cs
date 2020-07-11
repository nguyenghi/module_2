using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Models
{
    public class BookRepository : IBookRepository


    {

        private readonly AppDbContext context;
        public BookRepository (AppDbContext context)
        {
            this.context = context;

        }
        public Book Create(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return book;
        }
            public bool Delete(int id)
        {
            var delBook = context.Books.Find(id);
            if (delBook != null)
            {
                context.Books.Remove(delBook);
                return context.SaveChanges() > 0;
            }
            return false;

        }

        public Book Edit(Book book)
        {
            var editBook = context.Books.Attach(book);
            editBook.State = EntityState.Modified;
            context.SaveChanges();
            return book;
        }

        public BookDetailViewModel Get(int id)
        {
            var data = (from b in context.Books
                        join g in context.Genres on b.GenreId equals g.GenreId
                        where b.Id == id
                        select new BookDetailViewModel()
                        {
                            Id = b.Id,
                            Name = b.Name,
                            Author = b.Author,
                            Price = b.Price,
                            Depscrip = b.Depscrip,
                            GenreName = g.GenreName,
                            AvatarPath =b.AvatarPath,
                            GenreId= b.GenreId,
                            Remain = b.Remain


                        }).FirstOrDefault();
            return data;

        }
      
        public IEnumerable<Book> Gets()
        {
            return context.Books;
        }

        
    }
}
