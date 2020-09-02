using System;

namespace Case_Study_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Service ser = new Service();
        Main:
            var categories = ser.GetAllCategory();
            do
            {
                if (categories.Count > 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("________________________________");
                    Console.WriteLine("|1: Product Management         |");
                    Console.WriteLine("|2: Category Management        |");
                    Console.WriteLine("|0: Exit                       |");
                    Console.WriteLine("|______________________________|");
                    Console.Write("Your choice:");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("\n---------------------------------------");
                                Console.WriteLine("1: Add new product");
                                Console.WriteLine("2: Remove a product");
                                Console.WriteLine("3: Update a product");
                                Console.WriteLine("4: Get all product");
                                Console.WriteLine("0: Back");
                                int choice2 = Int32.Parse(Console.ReadLine());
                                switch (choice2)
                                {
                                    case 1:
                                        Product p = new Product();
                                        Console.WriteLine("Select a category: ");
                                        for (int i = 0; i < categories.Count; i++)
                                        {
                                            Console.WriteLine("{0} Category {1}", i + 1, categories[i].CategoryName);
                                        }
                                        Console.Write("Your choice: ");
                                        int choiceCat = Int32.Parse(Console.ReadLine());
                                        p.CategoryId = categories[choiceCat - 1].CategoryId;
                                        Console.Write("Enter Product id: ");
                                        p.ProductId = Int32.Parse(Console.ReadLine());
                                        Console.Write("Enter Product Name: ");
                                        p.ProductName = Console.ReadLine();
                                        Console.Write("Enter Price: ");
                                        p.Price = Int32.Parse(Console.ReadLine());
                                        ser.AddProducts(p);
                                        Console.WriteLine("Added new Product!");
                                        break;
                                    case 2:
                                        Console.Write("Enter a product id you want to remove: ");
                                        int idRemove = Int32.Parse(Console.ReadLine());
                                        ser.RemoveProduct(idRemove);
                                        Console.WriteLine("Removed products!");
                                        break;
                                    case 3:
                                        Product prod = new Product();
                                        Console.Write("Enter product id to edit: ");
                                        prod.ProductId = Int32.Parse(Console.ReadLine());
                                        Console.Write("Enter product name to edit: ");
                                        prod.ProductName = Console.ReadLine();
                                        Console.Write("Enter price to edit: ");
                                        prod.Price = Int32.Parse(Console.ReadLine());
                                        ser.UpdateProduct(prod);
                                        Console.WriteLine("Updated!");
                                        break;
                                    case 4:
                                        ser.ShowAllProducts();
                                        break;
                                    case 0:
                                        goto Main;
                                    default:
                                        Environment.Exit(0);
                                        break;
                                }
                            } while (true);
                        case 2:
                            do
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("1: Add new category");
                                Console.WriteLine("2: Remove a category");
                                Console.WriteLine("3: Update a category");
                                Console.WriteLine("4: Get all category");
                                Console.WriteLine("0: Back");
                                int choice2 = Int32.Parse(Console.ReadLine());
                                switch (choice2)
                                {
                                    case 1:
                                        Category cat = new Category();
                                        Console.WriteLine("Enter category id: ");
                                        cat.CategoryId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter category name: ");
                                        cat.CategoryName = Console.ReadLine();
                                        ser.AddCategory(cat);
                                        Console.WriteLine("---------------Added category !-----------");
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter category id to remove: ");
                                        int id = Int32.Parse(Console.ReadLine());
                                        ser.RemoveCategory(id);
                                        Console.WriteLine("---------------Removed category!----------");
                                        break;
                                    case 3:
                                        Category catToUpdate = new Category();
                                        Console.WriteLine("Enter category id to edit: ");
                                        catToUpdate.CategoryId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter category name to edit: ");
                                        catToUpdate.CategoryName = Console.ReadLine();
                                        ser.UpdateCategory(catToUpdate);
                                        Console.WriteLine("------------Updated category!-------------");
                                        break;
                                    case 4:
                                        ser.ShowAllCategories();
                                        break;
                                    case 0:
                                        goto Main;
                                    default:
                                        Environment.Exit(0);
                                        break;
                                }
                            } while (true);
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Category c = new Category();
                    bool idCorrect = true;
                AddNewCateogry:
                    do
                    {
                        Console.WriteLine("Enter new category to continue!");
                        Console.Write("Enter new category id: ");
                        string idString = Console.ReadLine();
                        if (idString != "")
                        {
                            int categoryId = Int32.Parse(idString);
                            bool isExist = ser.CheckCategoryExist(categories, categoryId);
                            if (!isExist)
                            {
                                c.CategoryId = categoryId;
                                idCorrect = false;
                            }
                        }
                    } while (idCorrect);
                    Console.Write("Enter cateogy name: ");
                    c.CategoryName = Console.ReadLine();

                    ser.AddCategory(c);
                    Console.WriteLine("--------Add Category Success !--------");
                    Console.WriteLine("Do you want to create new category ?");
                    Console.Write("Y/N: ");
                    string choice = Console.ReadLine();
                    if (choice == "y" || choice == "Y")
                    {
                        goto AddNewCateogry;
                    }
                    else
                    {
                        goto Main;
                    }
                }
            } while (true);
        }
    }
}
