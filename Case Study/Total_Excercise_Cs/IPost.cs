using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Excercise_Cs
{
    public interface IPost
    {
        public string Display();
        public float CalculatorRate();
    }
    public class Post : IPost
    {
        private int id = 0;
        private string title;
        private string content;
        private string author;
        private float averageRate;
        public List<int> Rates = new List<int>();
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Author { get => author; set => author = value; }
        public float AverageRate { get => averageRate; private set => averageRate = value; }

        public Post()
        {
            ++Id;
        }       
        public string Display()
        {
            return "Id: " + Id + "  -  " + "title: " + Title + "  -  " + "content: " + Content + "  -  " + "author: " +
                Author + "  -  " + "Count: " + Rates.Count + "  -  " + "AverageRate: " + AverageRate;
        }

        public float CalculatorRate()
        {
            int total = 0;
            foreach (var idx in Rates)
            {
                total += idx;
            }
            AverageRate = total / Rates.Count;
            return AverageRate;
        }
    }
}
