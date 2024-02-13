using System;
class Program
{
    public void Main(string[] args)
    {
        Console.Write("Enter any number :");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} is even");
        }else
        {
            Console.WriteLine("Number is odd");
        }
    }
}