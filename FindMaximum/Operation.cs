﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Operation
    {
        public T FindMax<T>(T a, T b, T c) where T : IComparable
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

    }
}