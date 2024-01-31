// Practice 
/*
{

    int rishu = 4;
    Console.WriteLine("Hello my name is Amardeep and my favorite number is " + rishu);
    Console.WriteLine($"Hello my name is Amardeep and my favorite number is {rishu}");
    Console.WriteLine("Hello my name is Amardeep and my favorite number is {0}",rishu);

     Data Types 

    int rishu = 37; integer type -- 4 bytes
    float number = 8.7; floating / decimal type  -- 4 byte 
    char a = 'A'; character type - 2 bytes 
    bool isGreat = true; boolean type  -- 1 bit
   string inp = "Rishu";  string type data type   -- 2 bytes per character  
   


string inp = Console.ReadLine();
    Console.WriteLine(inp);
   




}

 
    


using System.Collections.Concurrent;

{
    // type casting
    int a = (int) 32.5;  // double to integer typecasting
    Console.WriteLine(a); //32

    // there are 2 types of type casting
    // 1. Implicit casting  -- char to int to long to float to double

    int x = 3;
    double w = x;
    int z = 'y';
    Console.WriteLine(z);
    Console.WriteLine(w);

    // 2. Explicit casting  -- 

}




// Program to check whether the entered number is even or odd.

using System;


namespace Practice { 

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int input = int.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("It is even number ");
            }else
            {
                Console.WriteLine("It is odd");
            }


        }
    }


}


using System;

namespace practice
{
    class programs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            string number = Console.ReadLine();

            if (int.TryParse(number, out int value))
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine("The entered number is even.");
                }
                else
                {
                    Console.WriteLine("The entered number is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number entered. Please try again.");
            }
        }
    }
}


//This C# Program Generates Odd Numbers within a Range.
using System;
namespace practice
{
    class problems
    {
        static void Main(string[]args) {

            Console.Write("Enter start value : ");
            int  start  = int.Parse(Console.ReadLine());
            Console.Write("Enter end value : ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"Odd numbers between {start} and {end}");
            // ensures the start is odd if it's not
            if (start % 2 == 0)
            {
                start++;
            }
            for (int i = start; i <=end; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}




// program to check whether a number is positive or not 

using System;

namespace program
{
    class practice
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int number= int.Parse(Console.ReadLine());

            if(number > 0  )
            {
                Console.WriteLine($"{number} is positive ");

            }else if ( number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }
            else if ( number == 0 ) 
            {
                Console.WriteLine("Number is 0");
            }else
            {
                Console.WriteLine("Incorrect number entered . Please try again ");
            }
        }
    }
}

*/

using System;

namespace program
{
    class practice
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                if (number > 0)
                {
                    Console.WriteLine($"{number} is positive ");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"{number} is negative");
                }
                else
                {
                    Console.WriteLine("Number is 0");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

