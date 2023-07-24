using System;
namespace FindMaximum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Operation operation = new Operation();
            Console.WriteLine(operation.FindMax(1, 2, 3));
            Console.WriteLine(operation.FindMax(1.6f, 2.2f, 3.4f));
            Console.WriteLine(operation.FindMax("adfsd","eqwfw","iufvuyf"));
        }
    }
}