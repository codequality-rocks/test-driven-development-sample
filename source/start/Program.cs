using System;

namespace start
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Hi welcome to your delivery master! What do you want to eat today?");
            Console.WriteLine("You can choose the following options:");
            Console.WriteLine("1) Burger");
            Console.WriteLine("2) Sushi");
            Console.WriteLine("3) Pasta");
            Console.WriteLine("4) Chicken");
            Console.WriteLine("Please provide an option by submitting a number");
            var input = Console.ReadLine();
        }
    }
}
