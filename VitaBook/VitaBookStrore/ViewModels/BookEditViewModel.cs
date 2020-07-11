using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.Models;

namespace VitaBookStrore.ViewModels
{
    public class BookEditViewModel : BookCreateViewModel
    {
        public int Id { get; set; }
        public string AvtPath { get; set; }
    }
}

