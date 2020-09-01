using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPublication
{
    public abstract class Publication
    {
        private string uniqueID;
        public string Publisher { get; set; }
        public string Title { get; set; }
        public abstract void MakeCover();

        protected void Publish()
        {
            Console.WriteLine($"Published on {DateTime.Now.ToString()}");
        }
    }
    public class Book : Publication
    {
        public override void MakeCover()
        {
            Console.WriteLine("Book Cover");
        }
    }
    public class Magazine : Publication
    {
        public override void MakeCover()
        {
            Console.WriteLine("Magazine cover");
        }
    }
}
