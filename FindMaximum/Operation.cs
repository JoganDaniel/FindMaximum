using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Operation<T> where T : IComparable
    {
        public T[] a;
        public Operation(T[] a)
        {
            this.a = a;
        }
     
        public T FindMax()
        {
            Array.Sort(this.a);
            return a[^1];
        }
      
    }
}