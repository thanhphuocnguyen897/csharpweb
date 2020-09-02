using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study_Cs
{
    public class Category
    {
        private int categoryId;
        private string categoryName;

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public override string ToString()
        {
            return "Id " + CategoryId + " Name " + CategoryName;
        }
    }
}
