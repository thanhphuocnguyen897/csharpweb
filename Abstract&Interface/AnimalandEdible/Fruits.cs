using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalandEdible
{
    public abstract class Fruits : Edible
    {
        public abstract string HowtoEat();
    }
    public class Apple : Fruits
    {
        public override string HowtoEat()
        {
            return "Apple could be sliced";
        }
    }
    public class Orange : Fruits
    {
        public override string HowtoEat()
        {
            return "Orange could be juiced";
        }
    }
}
