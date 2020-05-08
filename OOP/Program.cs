using System;
namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employlist = new Employee[0];
            int option = -1;
            while (option != 4)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Tao mang employees");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Tim ten");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Nhap su lua chon ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ArrEmployee(ref employlist);
                        break;
                    case 2:
                        DisplayEmp(employlist);
                        break;
                    case 3:
                        Console.Write("Nhap ten can tim");
                        string name = Console.ReadLine().ToLower();
                        FindName(employlist, name);
                        break;
                    case 4:
                        Environment.Exit(Environment.ExitCode);
                        break;
                }
            }
        }
        public static void ArrEmployee(ref Employee[] employeearr)
        {
            int n;
            Console.Write("Nhap so luong nhan vien n: ");
            n = Int32.Parse(Console.ReadLine());
            Array.Resize(ref employeearr, n);
            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();
                Console.Write("Nhap ho ten: ");
                employee.Name = Console.ReadLine();
                Console.Write("Nhap email: ");
                employee.Email = Console.ReadLine();
                Console.Write("Nhap dia chi: ");
                employee.Address = Console.ReadLine();
                Console.Write("Nhap ngay sinh");
                employee.Dob = DateTime.Parse(Console.ReadLine());
                employeearr[i] = employee;
            }
            if (n == 0)
            {
                Environment.Exit(Environment.ExitCode);
            }
        }
        public static void DisplayEmp(Employee[] employeearr)
        {
            for (var i = 0; i < employeearr.Length; i++)
            {
                Console.WriteLine(employeearr[i].ShowInfo());
            }
        }
        public static void FindName(Employee[] employeearr, string name)
        {
            bool flag = true;
            for (int i = 0; i < employeearr.Length; i++)
            {
                if (employeearr[i].Name.ToLower() == name.ToLower())
                {
                    Console.WriteLine(employeearr[i].ShowInfo());
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Khong tim thay");
            }
        }
    }
}