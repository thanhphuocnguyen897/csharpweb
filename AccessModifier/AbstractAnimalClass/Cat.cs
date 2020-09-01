using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAnimalClass
{
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string weight, string height, string name) 
        : base(weight, height)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("The cat has:\nWeight: {0} \nHeight: {1} \nName: {2}", this.Weight, this.Height, this.Name);
        }

    }
}
