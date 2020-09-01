using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalandEdible
{
    public abstract class Animal
    {
        public abstract string Makesound();
    }
    public class Tiger : Animal
    {
        public override string Makesound()
        {
            return "Tiger roarrrrrr!";
        }
    }
    public class Chicken : Animal, Edible
    {
        public override string Makesound()
        {
            return "Chicken cluck-clucks!";
        }
        public string HowtoEat()
        {
            return "could be fried";
        }
    }
}
