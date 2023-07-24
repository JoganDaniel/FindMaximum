using System;
namespace FindMaximum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.FindMaxInteger(1,2,3);
            operation.FindMaxFloat(1.2f, 1.6f, 2.1f);
            operation.FindMaxString("abc", "defeff", "zxcvv");
        }
    }
}