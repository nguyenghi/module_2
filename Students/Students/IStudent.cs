using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    interface IStudent
    {
        public string Fullame { get; set; }
        public int ID { get; set; }
        public DateTime DayofBirth { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        public void Display();
    }
}
