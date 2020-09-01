using System;
using System.Collections;
using System.Linq;

namespace ArrayListandLinQExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList staffList = new ArrayList();
            staffList.Add(new Staff { Id = 1, Name = "Nam", Age = 24 });
            staffList.Add(new Staff { Id = 2, Name = "Kien", Age = 21 });
            staffList.Add(new Staff { Id = 3, Name = "Viet", Age = 21 });
            staffList.Add(new Staff { Id = 4, Name = "Hang", Age = 23 });
            staffList.Add(new Staff { Id = 5, Name = "Tien", Age = 24 });
            var subset = from Staff thestaff in staffList
                         where thestaff.Age < 24
                         orderby thestaff.Id
                         select thestaff;
            foreach (Staff thestaff in subset)
            {
                Console.WriteLine(thestaff.Id + " " + thestaff.Name + "   " + thestaff.Age);
            }
        }
    }
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
