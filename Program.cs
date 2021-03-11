using System;

namespace PracticaGitHub
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a ,b = 0;
            
            Console.WriteLine("Enter a value for a: ");
            a =Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine ( $"Subtraction {a} + {b} equals {SubtractionNumbers(a, b)} ");

        }
        static int SubtractionNumbers(int a, int b)
        {
    
            return a-b;
        }
    }
}