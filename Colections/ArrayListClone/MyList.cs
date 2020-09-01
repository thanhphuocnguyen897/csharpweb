using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayListClone
{
    class MyList<T>
    {
        public virtual int Capacity { get; set; }
        public virtual int Count { get; }
        public virtual bool IsFixedSize { get; }
        public virtual bool IsReadOnly { get; }

        public MyList(){}
        public MyList(System.Collections.ICollection c){}
        public MyList(int capacity)
        {
            Capacity = capacity;
        }
    }
}
