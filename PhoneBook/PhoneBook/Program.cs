using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contact[] PhoneList = new Contact[0];
            PhoneBooks phoneBooks = new PhoneBooks();
            int option = -1;
            while (option != 6)
            {
                Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Input your option ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Input name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input phonenumber");
                        string phonenumber = Console.ReadLine();
                        phoneBooks.InsertPhone(name, phonenumber);
                        option = -1;

                        break;
                    case 2:
                        Console.WriteLine("Input name to remove");
                        string nameRemove = Console.ReadLine();
                        phoneBooks.RemovePhone(nameRemove);
                        option = -1;
                        break;
                    case 3:
                        Console.WriteLine("Input name ");
                        string nameUpdate = Console.ReadLine();
                        Console.WriteLine("Input phonenumber");
                        string newphonenumber = Console.ReadLine();
                        phoneBooks.UpdatePhone(nameUpdate, newphonenumber);
                        option = -1;
                        break;
                    case 4:
                        Console.WriteLine("Input name");
                        string nameSearch = Console.ReadLine();
                        phoneBooks.SearchPhone(nameSearch);
                        option = -1;
                        break;
                    case 5:
                        phoneBooks.Sort();
                        for (int i= 0; i<phoneBooks.PhoneList.Length; i++)
                        {
                            phoneBooks.ShowContact(i);
                        }
                        option = -1;
                        break;
                    case 6:
                        Environment.Exit(Environment.ExitCode);
                        break;
                }
            }
            


        }
    }
}
