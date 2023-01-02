using System;

namespace C__practice
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter your first number");
          int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
