using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class PhoneBooks : Phone
    {

        #region fields

        public Contact[] PhoneList = new Contact[0];

        private int numberOfContacts => PhoneList.Length;

        #endregion


        #region public methods
        public override void InsertPhone(string name, string phoneNumber)
        {
            Array.Resize(ref PhoneList, numberOfContacts + 1);

            PhoneList[numberOfContacts - 1] = new Contact() 
                                                {
                                                    Name = name,
                                                    PhoneNumber = phoneNumber
                                                };

            Console.WriteLine("Insert new contact successfully");
        }

        
        public override void RemovePhone(string name)
        {
            var pos = Check(name);

            if (pos >= 0)
            {
                for (int j = pos; j < numberOfContacts - 1; j++)
                {
                    PhoneList[j] = PhoneList[j + 1];
                }
                Array.Resize(ref PhoneList, numberOfContacts - 1);

                Console.WriteLine("remove a contact successfully");
            }
            else
            {
                Console.WriteLine("not found contact");
            }
        }

        public override void SearchPhone(string name)
        {
            var pos = Check(name);
            if (pos!= -1)
            {
                ShowContact(pos);

            }
            
            
            
        }

        public override void Sort()
        {
            //IComparer<Contact> contactname = new ContactNameCompare();
            //Array.Sort(PhoneList, contactname);
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            var pos = Check(name);
            if (pos != -1)
            {
                PhoneList[pos].PhoneNumber = newPhone;
                ShowContact(pos);


            }


        }

        #endregion


        #region private methods

        private int Check(string name)
        {
            for (int i = 0; i < numberOfContacts; i++)
            {
                if (string.Compare(PhoneList[i].Name, name) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public string ShowContact(int pos)
        {
            return $" Name{PhoneList[pos].Name}, Phonenumber{PhoneList[pos].PhoneNumber}";
        }
        #endregion

        private void Swap(ref Contact ct1, ref Contact ct2)
        {
            Contact ctTem = new Contact();
            if(string.Compare(ct1.Name , ct2.Name) == 1)
            {
                ctTem = ct1;
                ct1 = ct2;
                ct2 = ctTem;
            }
        }

    }
}
