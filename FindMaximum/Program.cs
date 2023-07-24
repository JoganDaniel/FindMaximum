using System;
using System.Collections.Generic;

namespace FindMaximum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Operation<string> operation = new Operation<string>("adfsd", "eqwfw", "iufvuyf");
            Console.WriteLine("Max : "+operation.PrintMax());
        }
    }
}