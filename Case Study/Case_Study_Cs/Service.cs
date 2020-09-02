using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Case_Study_Cs
{
    public class Service
    {
        //Method with Categories File
        List<Product> products = new List<Product>();
        List<Category> categories = new List<Category>();
        string productFile = "products.txt";
        string categoryFile = "categories.txt";
        public List<Category> GetAllCategory()
        {
            categories = new List<Category>();
            using (StreamReader readcat = new StreamReader(categoryFile))
            {
                string line;
                while ((line = readcat.ReadLine()) != null)
                {
                    Category c = new Category();
                    c.CategoryId = Int32.Parse(line.Split("-")[0].Split(":")[1]);
                    c.CategoryName = line.Split("-")[1].Split(":")[1];
                    categories.Add(c);
                }
                return categories;
            }
        }
        public void WriteCategoryFile(List<Category> categories)
        {
            using (TextWriter writer = new StreamWriter(categoryFile))
            {
                for(int i = 0; i < categories.Count; i++)
                {
                    writer.WriteLine(string.Format("Id: {0} - Category Name: {1}", 
                        categories[i].CategoryId, categories[i].CategoryName));
                }
            }
        }
        public void AddCategory(Category c)
        {
            categories = GetAllCategory();
            categories.Add(c);
            WriteCategoryFile(categories);
        }
        public void UpdateCategory(Category cat)
        {
            categories = GetAllCategory();
            foreach(var Id in categories)
            {
                if(Id.CategoryId == cat.CategoryId)
                {
                    Id.CategoryName = cat.CategoryName;
                }
            }
            WriteCategoryFile(categories);
        }
        public void RemoveCategory(int id)
        {
            categories = GetAllCategory();
            Category cal = new Category();
            foreach (var item in categories)
            {
                if(item.CategoryId == id)
                {
                    cal = item;
                }
            }
            categories.Remove(cal);
            WriteCategoryFile(categories);
        }
        public string GetCategoryName(List<Category> categories, int Id)
        {
            string Name = "";
            foreach(var item in categories)
            {
                if(item.CategoryId == Id)
                {
                    Name = item.CategoryName;
                }
            }
            return Name;
        }
        public void ShowAllCategories()
        {
            categories = GetAllCategory();
            foreach (var item in categories)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public bool CheckCategoryExist(List<Category> categories, int id)
        {
            bool isExist = false;
            foreach(var item in categories)
            {
                if(item.CategoryId == id)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        //Method with Products File.
        public List<Product> GetAllProducts()
        {
            products = new List<Product>();
            using(StreamReader readprod = new StreamReader(productFile))
            {
                string line;
                while((line = readprod.ReadLine()) != null)
                {
                    Product p = new Product();
                    var data = line.Split("-");
                    p.ProductId = Int32.Parse(data[0].Split(":")[1]);
                    p.ProductName = data[1].Split(":")[1];
                    p.Price = Int32.Parse(data[2].Split(":")[1]);
                    products.Add(p);
                }
                return products;
            }
        }
        public void WriteProductFile(List<Product> products) 
        {
            using (TextWriter writer = new StreamWriter(productFile))
            {
                foreach(var product in products)
                {
                    string categoryName = GetCategoryName(categories, product.CategoryId);
                    writer.WriteLine(string.Format("Id: {0} - Product Name: {1} - Price: {2} - Category Id: {3} - Category Name: {4}", 
                        product.ProductId, product.ProductName, product.Price, product.CategoryId, categoryName));
                }
            }
        }
        public void AddProducts(Product product)
        {
            products = GetAllProducts();
            products.Add(product);
            WriteProductFile(products);
        }
        public void UpdateProduct(Product prod)
        {
            products = GetAllProducts();
            foreach(var item in products)
            {
                if(prod.ProductId == item.ProductId)
                {
                    item.ProductName = prod.ProductName;
                    item.Price = prod.Price;
                }
            }
            WriteProductFile(products);
        }
        public void RemoveProduct(int productId)
        {
            products = GetAllProducts();
            Product p = new Product();
            foreach(var item in products)
            {
                if(item.ProductId == productId)
                {
                    p = item;
                }
            }
            products.Remove(p);
            WriteProductFile(products);
        }
        public void ShowAllProducts()
        {
            products = GetAllProducts();
            foreach(var item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public bool CheckProductExist(List<Product> products, int id)
        {
            bool isExist = false;
            foreach (var item in products)
            {
                if (item.ProductId == id)
                {
                    isExist = true;
                }
            }
            return isExist;
        }
    }
}
