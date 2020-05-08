using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static Dictionary<int, Student> ListStudent = new Dictionary<int, Student>();
        static int emp = 1;
        static void Main(string[] args)
        {
            int option = -1;
            while (option != 4)
            {
                Console.WriteLine("Student Managemnet System");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Search Students");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Input your option");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InsertStudent();
                        option = -1;
                        break;
                    case 2:
                        ViewListStudent();
                        option = -1;

                        break;
                    case 3:
                        Console.Write("Input namesearch: ");
                        string namesearch = Console.ReadLine();
                        SearchStudent(namesearch);
                        option = -1;

                        break;
                    case 4:
                        Environment.Exit(Environment.ExitCode);
                        break;
                }
            }
        }
        public static void InsertStudent()
        {
            Student student = new Student();
            Console.Write("Input Name:");
            student.Fullame = Console.ReadLine();
            Console.Write("Input DayofBirth: ");
            student.DayofBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Input Native:");
            student.Native = Console.ReadLine();
            Console.Write("Input Class:");
            student.Class = Console.ReadLine();
            Console.Write("Input PhoneNo:");
            student.PhoneNo = Console.ReadLine();
            Console.Write("Input Mobile:");
            student.Mobile = Int32.Parse(Console.ReadLine());
            student.ID = emp;
            
            ListStudent.Add(emp,student);
            emp++;
            

        }
        public static void ViewListStudent()
        {
            foreach (var item in ListStudent)
            {
                item.Value.Display();

            }

        }
        public static void SearchStudent(string name)
        {
            int pos = -1;

            for (int i = 1; i < ListStudent.Count; i++)
            {
                if (name == ListStudent[i].Fullame)
                {
                    pos =ListStudent[i].ID;
                }

            }
            if(pos!= -1)
            {
                ListStudent[pos].Display();
            }
            else
            {
                Console.WriteLine("Student not exits");
            }
        }

    }
}
