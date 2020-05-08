using System;

namespace OOP2
{
    class Contact
    {
        private string name;
        private string phonenumber;
        public Contact(string _name, string _phonenumber)
        { this.name = _name;
         this.phonenumber = _phonenumber;


        }
        public string Name{
            get => name;
            set => name = value ;
        }
        public string PhoneNumber{
            get => phonenumber;
            set => phonenumber = value;
        }
    }
    class PhoneBook
    {
        public Contact[] ContactList = new Contact [0] ;

        public void AddContact(Contact contact)
        {
            Array.Resize(ref ContactList, ContactList.Length + 1);
            ContactList[ContactList.Length - 1] = contact;

        }
         public  bool CheckName(string name)
        {
            
            for(int i =0;i< ContactList.Length;i++)
            {
                if(name.ToLower()== ContactList[i].Name.ToLower())
                {
                    return true;
                }
                           
            }
            return false;
        }
        public void UpdateContact( string name)  

        {
            for( int i= 0; i< ContactList.Length; i++)
            {
                if(name.ToLower()== ContactList[i].Name.ToLower())
                {
                    string newphone ="";
                    Console.Write("Nhap newphone:");
                    newphone = Console.ReadLine();
                    ContactList[i].PhoneNumber = newphone;
                }

            }
        } 
        public void RemoveContact(string name)
        { 
            bool flag = false;
         for(int i =0;i< ContactList.Length;i++)
            {
                if(name.ToLower()== ContactList[i].Name.ToLower())
                {
                    flag= true;

                    for (int j = i; j < ContactList.Length - 1; j++)
                    {
                        ContactList[j] = ContactList[j + 1];
                    }
                
                }


            }
            if( flag == true)
            {
                Array.Resize(ref ContactList, ContactList.Length -1);

            }
         

        }
        public void SearchName( string name)
        {
              bool flag = false;
           
            for (int i = 0; i < ContactList.Length; i++)
            {
                if (name.ToLower() == ContactList[i].Name.ToLower())
                {
                   Console.Write("Ten: {0}, so dien thoai: {1}", ContactList[i].Name, ContactList[i].PhoneNumber);
                    flag = true;
                }
            }
            if(flag==false)
            {
                Console.Write("Not exists");
            }
            
        }
        public void ShowContact()
        {
             for (int i = 0; i < ContactList.Length; i++)
            {  
             Console.Write("Ten: {0}, so dien thoai: {1}", ContactList[i].Name, ContactList[i].PhoneNumber);
                    
            }
        }

    }

}