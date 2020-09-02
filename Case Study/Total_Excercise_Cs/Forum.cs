using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Total_Excercise_Cs
{
    public class Forum
    {
        public SortedList<int, Post> Posts = new SortedList<int, Post>();
        public void Add(int id, Post p)
        {
            Posts.Add(p.Id, p);
        }
        public void Update(Post factor)
        {
            foreach(var item in Posts)
            {
                if(factor.Id == item.Key)
                {
                    factor.Content = item.Value.Content;
                    factor.Title = item.Value.Title;
                }
                else
                {
                    Console.WriteLine("Invalid id!!");
                }
            }
        }
        public void Remove(int id)
        {
                Posts.RemoveAt(id);
        }
        public void ShowAllPost()
        {
            foreach(var item in Posts)
            {
                Console.WriteLine(item.Value.Display());
            }
        }
        public string FindPostWithTitle(string title)
        {
            foreach(var item in Posts)
            {
                if (title == item.Value.Title)
                {
                    return item.Value.Display();
                }
            }
            return null;
        }
        public string FindPostWithAuthor(string author)
        {
            foreach (var item in Posts)
            {
                if (author == item.Value.Author)
                {
                    return item.Value.Display();
                }
            }
            return null;
        }
        public void Rate(int star, int id)
        {
            foreach(var item in Posts)
            {
                try
                {
                    if (id == item.Value.Id)
                    {
                        item.Value.Rates.Add(star);
                    }
                }
                catch(KeyNotFoundException e)
                {
                    Console.WriteLine(e + "Invalid Id");
                }
            }
        }
        public float GetAverageRate(int id)
        {
            foreach (var item in Posts)
            {
                if (id == item.Value.Id)
                {
                    return item.Value.CalculatorRate();
                }
            }
            return 0;
        }
    }
}
