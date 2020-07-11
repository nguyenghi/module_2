using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.ViewModels
{
    public class BookDetailViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Author { get; set; }
        public string AvatarPath { get; set; }


        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string Depscrip { get; set; }
        public int Remain { get; set; }

        
    }
}
