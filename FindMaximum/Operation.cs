using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Operation<T> where T : IComparable
    {
        public T a, b, c;
        public Operation(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
     
        public T FindMax(T a, T b, T c) 
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            if (c.CompareTo(a) >= 0 && c.CompareTo(b) >= 0)
            {
                return c;
            }
            return a;
        }
        public T PrintMax()
        {
            T ans = FindMax(this.a, this.b, this.c);
            return ans;
        }
    }
}