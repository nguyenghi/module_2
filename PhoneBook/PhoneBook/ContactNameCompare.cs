using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class ContactNameCompare : IComparer<Contact>
    {
        public int Compare(Contact contact1,Contact contact2)
        {
            return string.Compare(contact1.Name, contact2.Name); //contact1.Name.CompareTo(contact2.Name);
        }
    }
}
