using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study_Cs
{
    public class Product
    {
        private int productId;
        private string productName;
        private int price;
        private int categoryId;

        public int Price { get => price; set => price = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }

        public override string ToString()
        {
            return "Id " + ProductId + " Name " + ProductName + ": " + Price;
        }
    }
}
