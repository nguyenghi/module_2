using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student : IStudent
    {
        private string fullname;
        private int id;
        private DateTime dayofbirth;
        private string native;
        private string _class;
        private string phoneno;
        private int mobile;
        
        
        public string Fullame 
        {   get => fullname; 
            set =>fullname= value; 
        }

        public int ID 
        {   get => id;
            set => id= value;
        }
        public DateTime DayofBirth
        {   get => dayofbirth;
            set => dayofbirth= value; 
        }

        public string Native 
        { get => native;
            set => native= value;
        }


        public string Class
        {   get => _class;
            set => _class= value; 
        }
        public string PhoneNo 
        {   get => phoneno; 
            set => phoneno= value;
        }
        public int Mobile
        {   get => mobile ;
            set => mobile= value;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Name: {Fullame}\t" +
                $"ID: {ID}\t  " +
                $"DayofBirth: {DayofBirth}\t" +
                $"Native: {Native}\t" +
                $"Class: {Class}\t" +
                $"PhoneNo: {PhoneNo}\t" +
                $"Mobile: {Mobile} " 
                
                
                              

                );
        }
    }
}
