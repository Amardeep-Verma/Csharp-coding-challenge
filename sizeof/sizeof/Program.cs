using System;

namespace size_of
{
    internal class Program
    {
        // C# program to print size of various data types

        static void Main(string[] args)
        {
            Console.WriteLine("sizeof(int): {0}", sizeof(int));
            Console.WriteLine("sizeof(float): {0}", sizeof(float));
            Console.WriteLine("sizeof(char): {0}", sizeof(char));
            Console.WriteLine("sizeof(double): {0}", sizeof(double));
            Console.WriteLine("sizeof(bool): {0}", sizeof(bool));
            Console.WriteLine("sizeof(long): {0}", sizeof(long));
        }
    }
}
