using System;
using System.Collections.Generic;

namespace FindMaximum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] a = {"ghcygc","avdvsd","ecgfcg","plncb","ftytvyd","qwertyu"};
            Operation<string> operation = new Operation<string>(a);
            Console.WriteLine("Max value : "+operation.FindMax());
        }
    }
}