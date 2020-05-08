using System;

namespace timten
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] name ={"tram","minh","quang","trung","tin","ghi"};
            Console.WriteLine("Nhap ten hoc vien");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < name.Length; i++)
            {
                    if (name[i].Equals(input_name))
                        {
                         Console.WriteLine("vi tri trong danh sach cua " + input_name + " la: " + (i + 1));
                         isExist = true;
                            break;
                        }
            }
            if (!isExist)
                {
                    Console.WriteLine("khong tim thay" + input_name + " trong danh sach.");
                }
        }
    }
}
