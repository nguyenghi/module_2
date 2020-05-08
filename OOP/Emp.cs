 using System;
namespace OOP
{
   class Employee
    {
        private string name;
        private string email;
        private string address;
        private DateTime dob;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public DateTime Dob
        {
            get => dob;
            set => dob = value;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - dob.Year;
        }
        public string ShowInfo()
        {
            return " name " + name + ",age " + GetAge() + ", email " + email + " , address " + address;
        }
    }
}