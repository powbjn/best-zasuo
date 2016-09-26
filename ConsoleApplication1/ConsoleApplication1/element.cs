using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class element<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        element<T> next;
        internal element<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
