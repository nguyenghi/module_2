using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook  contactlist = new PhoneBook();
            int choice = -1;
            while(choice < 1 || choice > 6)
            {   
                Console.WriteLine("PhoneBook Management System");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Update Contact");
                Console.WriteLine("3. Remove Contact");
                Console.WriteLine("4. Search Contract");
                Console.WriteLine("5. Show Contacts");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            switch (choice)
            {   case 1:
                    Add(contactlist);
                    break;
                case 2:
                    Update(contactlist);
                    break;
                case 3:
                    Remove(contactlist);
                    break;
                case 4:
                    Search(contactlist);
                    break;
                case 5:
                    Show(contactlist);
                    break;
                case 6:
                     Environment.Exit(Environment.ExitCode);
                        break;
                
                
            }

            
        }
        static void Add( PhoneBook contact)
        {
                Console.Write("Nhap ten: ");
                 string name = Console.ReadLine();
                Console.Write("Nhap so dien thoai");
                string phonenumber = Console.ReadLine();
                Contact contact1 = new Contact(name, phonenumber);
                contact.AddContact(contact1);

                

            
        }
        static void Update( PhoneBook  contact )
        {   Console.Write("Nhap ten :");
            string name = Console.ReadLine();
           
             contact.UpdateContact( name);


            
        }
        static void Remove( PhoneBook contact)
        { Console.Write("Nhap ten can xoa:");
            string name = Console.ReadLine();
            contact.RemoveContact(name);

        }
        static void Search(PhoneBook contactlist){
            Console.Write("Nhap ten can xoa:");
            string name = Console.ReadLine();
            contactlist.SearchName(name);

        }
        static void Show(PhoneBook contactlist){
            contactlist.ShowContact();
        }
        
 
    }
}
