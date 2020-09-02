using System;
using System.Collections.Generic;

namespace Total_Excercise_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Forum forum = new Forum();
            
            do
            {
                Console.WriteLine("|----------------------------------|");
                Console.WriteLine("|---------------Menu---------------|");
                Console.WriteLine("| 1. Create Post:__________________|");
                Console.WriteLine("| 2. Update Post:__________________|");
                Console.WriteLine("| 3. Remove Post:__________________|");
                Console.WriteLine("| 4. Show Post:____________________|");
                Console.WriteLine("| 5. Search:_______________________|");
                Console.WriteLine("| 6. Rating:_______________________|");
                Console.WriteLine("| 7. Exit._________________________|");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Post p = new Post();
                        Console.WriteLine("Create new post: ");
                        Console.Write("Enter title of your post: ");
                        p.Title = Console.ReadLine();
                        Console.Write("Enter author of your post: ");
                        p.Author = Console.ReadLine();
                        Console.Write("Enter content of your post: ");
                        p.Content = Console.ReadLine();
                        forum.Add(p.Id, p);
                        //Console.Write("Rate for id Post: ");
                        //int star = Int32.Parse(Console.ReadLine());
                        //forum.Rate(p.Id, star);
                        //forum.GetAverageRate(p.Id);
                        break;
                    case 2:
                        Post updateP = new Post();
                        Console.Write("Enter id of post you want to update: ");
                        int id = Int32.Parse(Console.ReadLine());
                        updateP.Id = id;
                        Console.Write("Enter new title: ");
                        string title = Console.ReadLine();
                        updateP.Title = title;
                        Console.Write("Enter new content: ");
                        string content = Console.ReadLine();
                        updateP.Content = content;
                        forum.Update(updateP);
                        break;
                    case 3:                     
                        try
                        {
                            Console.Write("Enter id post you want to remove: ");
                            int removeId = Int32.Parse(Console.ReadLine());
                            forum.Remove(removeId);
                        }
                        catch(KeyNotFoundException e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 4:
                        Console.WriteLine("All Posts are: ");
                        forum.ShowAllPost();
                        break;
                    case 5:
                        Console.WriteLine("Enter way to search: ");
                        Console.WriteLine("1. Search with Title: ");
                        Console.WriteLine("2. Search with Author: ");
                        int choice2 = Int32.Parse(Console.ReadLine());
                        
                        switch (choice2)
                        {
                            case 1:
                                Console.Write("Enter title to search: ");
                                string searchFactor1 = Console.ReadLine();
                                forum.FindPostWithAuthor(searchFactor1);
                                break;
                            case 2:
                                Console.Write("Enter title to search: ");
                                string searchFactor2 = Console.ReadLine();
                                forum.FindPostWithAuthor(searchFactor2);
                                break;
                        }
                        break;
                    case 6:
                        Console.Write("Please rating from 0 - 5 for Post with Id: ");
                        int ratingId = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter rate: ");
                        int rate = Int32.Parse(Console.ReadLine());
                        if(rate >5 || rate < 0)
                        {
                            forum.Rate(rate, ratingId);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect rate!");
                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect choice!");
                        break;
                }
            } while (true);
        }
    }
}
