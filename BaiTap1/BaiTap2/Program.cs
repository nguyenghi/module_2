using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Cryptography;

namespace BaiTap2
{
    class Program
    {
        public static Forum<Post> Posts = new Forum<Post>();
        //Post post = new Post(12,"abc","cde","fds");

        static void Main(string[] args)
        {

            int option = -1;
            while (option != 4)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Creat Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Post");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Input your option");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        CreatePost();
                        option = -1;
                        break;
                    case 2:
                        Console.WriteLine("Input id to update: ");
                        int idUpdate = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Input content to update: ");
                        string newcontent = Console.ReadLine();
                        Posts.UpdateContent(idUpdate, newcontent);
                        option = -1;

                        break;
                    case 3:
                        Console.WriteLine("Input id to remove: ");
                        int idremove = Int32.Parse(Console.ReadLine());
                        Posts.RemovePost(idremove);
                        option = -1;
                        break;
                    case 4:
                        Posts.ShowPosts();
                        break;
                    case 5:
                        Environment.Exit(Environment.ExitCode);
                        break;
                }
            }
        }
        public static void CreatePost()
        {
            Post post = new Post();
            Console.WriteLine("Input Id: ");
            post.ID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input title: ");
            post.Title = Console.ReadLine();
            Console.WriteLine("Input Content: ");
            post.Content = Console.ReadLine();
            Console.WriteLine("Input author: ");
            post.Author = Console.ReadLine();
            Console.WriteLine("Input ratearray: ");
            for (int i = 0; i< 3; i++)
            {
             Console.WriteLine("Input rate: ");
             post.Rate[i] = Int32.Parse(Console.ReadLine());


            }
            Posts.AddPost(post.ID, post);
        }
        
    }
}
