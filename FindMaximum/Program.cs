using System;
using System.Collections.Generic;

namespace FindMaximum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] a = {"ghcygc","avdvsd","ycgfcg","plncb","ftytvyd","qwertyu"};
            Operation<string> operation = new Operation<string>(a);
            operation.PrintMax();
        }
    }
}