using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.ViewModels
{
    public class RoleCreateViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
