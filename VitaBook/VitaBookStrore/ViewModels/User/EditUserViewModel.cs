using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.ViewModels.User
{
    
        public class EditUserViewModel
        {
            public string userId { get; set; }
            [EmailAddress]
            public string Email { get; set; }
            public string phoneNumber { get; set; }
            public string City { get; set; }
            public bool Gender { get; set; }
            public string RoleId { get; set; }


        }
    
}
