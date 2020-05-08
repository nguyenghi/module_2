using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2
{
    class Post:IPost
    {
        private int id { get; set; }
        private string title { get; set; } 

        private string content { get; set; }
        private string author { get; set; }
        private float averageRate { get; set; }
        public int[] rate = new int[3];
        public Post(int id, string title, string content, string author, int[] rate)
        {
            
        }
        public Post()
        {
        }
        public int ID
        {
            get => id;
            set => id = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Content
        {
            get => content;
            set => content = value;
        }
        public string Author
        {
            get => author;
            set => author = value;
        }
        public float AverageRate
        {
            get => averageRate;
        }
        public int [] Rate
        {
            get => rate;
            set => rate = value;
        }

        public string DisPlay()
        {
           return$"Id:{ID}\t" +
                $"Title: {Title}\t" +
                $"Content: {Content}\t" +
                $"Author: {Author}\t" +
                $"AverageRate: {CalculatorRate()}";
        }

        public float CalculatorRate()
        {
            var sum = 0;
            for(int i= 0; i< rate.Length; i++)
            {
                sum = sum + rate[i];
            }
            return sum/ rate.Length;
        }
    }
}
