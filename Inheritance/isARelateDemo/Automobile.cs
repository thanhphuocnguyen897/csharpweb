using System;
using System.Collections.Generic;
using System.Text;

namespace isARelateDemo
{
    public class Automobile
    {
        public string Make { get; }
        public string Model { get; }
        public string Year { get; }
        public Automobile(string make, string model, string year)
        {
            if(make == null)
            {
                throw new ArgumentNullException("The make cannot be NULL!");
            }
            else if (String.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be an empty string or have space characters only.");
            }
            Make = make;
            if(model == null)
            {
                throw new ArgumentNullException("The model cannot be NULL!");
            }
            else if (String.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Make cannot be an empty string or have space characters only.");
            }
            Model = model;
            if (year == null)
            {
                throw new ArgumentNullException("The model cannot be NULL!");
            }
            else if (String.IsNullOrWhiteSpace(year))
            {
                throw new ArgumentException("Make cannot be an empty string or have space characters only.");
            }
            Year = year;
        }
        public override string ToString() => $"{Year} {Model} {Make}";
        
    }
}
