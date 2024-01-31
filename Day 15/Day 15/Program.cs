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



// program to find largest of two numbers 

using System;
using System.Net.WebSockets;
using System.Transactions;
namespace practice
{
    class programs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number1= int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());    

            if(number1 > number2)
            {
                Console.WriteLine($"{number1} is greater than {number2}");

            }else if(number1 < number2)
            {
                Console.WriteLine($"{number2} is greater than {number1} ");

            }else if (number1 == number2)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}



using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                if (number1 > number2)
                {
                    Console.WriteLine($"{number1} is greater than {number2}");
                }
                else if (number1 < number2)
                {
                    Console.WriteLine($"{number2} is greater than {number1}");
                }
                else
                {
                    Console.WriteLine("Both numbers are equal");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
    }
}




// program to swap two numbers

using System;

namespace swap
{
    class Swapping
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string num1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string num2 = Console.ReadLine();

            if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
            {
                // Swapping the values using a temporary variable
                int temp = number1;
                number1 = number2;
                number2 = temp;

                Console.WriteLine($"After swapping: First number = {number1}, Second number = {number2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
    }
}

*/

// program to swap two numbers without using third varibale
using System;

namespace program
{
    class practice
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            string num2 = Console.ReadLine();

            if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
            {
                number1 = number1 + number2;
                number2 = number1 - number2;
                number1 = number1 - number2;

                Console.WriteLine("Swapped values are {0} and {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
    }
}

