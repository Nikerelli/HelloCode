using System;

namespace JuniorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Task1
        static bool CheckMultiplicityBy7And23(int value)
        {
            return value % 7 == 0 && value % 23 == 0; 
        }
    }
}
