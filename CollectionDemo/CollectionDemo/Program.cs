using System;
using System.Collections;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            ArrayList al1 = new ArrayList();
            al1.Add(1);
            al1.Add('2');
            al1.Add(null);
            al1.Add(new Student() { name= "ghi" });
            foreach (var item in al1)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < al1.Count; i++)
            {
                Console.WriteLine(al1[i]);
            }

        }
        class Student
        {
            public string name { get; set; }
        }
    }

}
