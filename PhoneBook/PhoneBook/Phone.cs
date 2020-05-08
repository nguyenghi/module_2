using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
     abstract class Phone
    {
        public abstract void InsertPhone(string name, string phonenumber);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();
        

        
         

    }
}
