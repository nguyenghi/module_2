using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class Contact
    {
        private string name { get; set; }
        private string phonenumber { get; set; }
        public Contact()
        {

        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string PhoneNumber
        {
            get => phonenumber;
            set => phonenumber = value;
        }

    }
}
