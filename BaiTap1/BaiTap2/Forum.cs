using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2
{
    class Forum <T> where T: class
    {
        SortedList<int, Post> Posts = new SortedList<int, Post>();
        public void AddPost(int id, Post Post)
        {
            Posts.Add(id, Post);
        }
        public void UpdateContent(int numberID, string newContent)
        {
            if(CheckID(numberID))
            {
                Posts[numberID].Content = newContent;
            }

        }
        public void RemovePost(int numberID)
        {
            if (CheckID(numberID))
            {
                Posts.RemoveAt(numberID);
            }
            else
            {
                Console.WriteLine(" Post not exits!");
            }
           

        }
        public void ShowPosts()
        {
            //foreach(var item in Posts.Keys)
            //{
            //    item.key.DisPlay(); 
            //}
            foreach(KeyValuePair<int, Post> Posts in Posts)
            {
                Posts.Value.DisPlay();
            }
        }
        public bool CheckID (int number)
        {
            bool flag = false;
            foreach(var item in Posts)
            {
                if( number== item.Key)
                {
                    flag = true;
                }
            }
            return flag;
        }

    }
}
