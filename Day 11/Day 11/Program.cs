// Object Oriented Programming 


/*
    Class - 
            1. A class is a blue print of an Object.
            2. It has actions / abilities - so called member functions or methods.
            3. and it has prooperties - so called member variables
            4. Inheritence possible .
            5. Can be used like a Datatype ( eg String is a Class )


    Object -
            1. 

 
{
    int i;
    Console.WriteLine("Enter a number");
    i = int.Parse(Console.ReadLine());  
    if(i % 2 == 0)
    {
        Console.WriteLine("Entered number is even ");
    }
    else
    {
        Console.WriteLine("Entered number is odd");

    }
   
}

{
    int number;
    Console.WriteLine("Enter a number");
    number=int.Parse(Console.ReadLine());
   if   (number > 0)
    {
        Console.WriteLine("Number is positive");
    }else if(number == 0) {
        Console.WriteLine("Number is 0");
    }else {
        Console.WriteLine("Number is negative");
            }
}



// program to find largest of two numbers

using System.Security.AccessControl;

{
    int i, j;
    Console.WriteLine("Enter first number");
    i = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number");
    j = int.Parse(Console.ReadLine());
    if (i > j)
    {
        Console.WriteLine("{0} is greater than {1}", i , j);
    }
    else
    {
        Console.WriteLine("{0} is greater than {1}",j , i);
    }
}



// Program to display all the prime numbers between 1 to 100
using System.Globalization;
using System.Net.Http.Headers;

{
    bool isPrime = true;
    Console.WriteLine("Prime Numbers :");
    for (int i = 2; i <=100; i++) { 
        for (int j = 2; j <=100; j++)
        {
            if  ( i != j && i % j == 0 )
            {
                isPrime = false;
                break;
            }

        }
        if ( isPrime )
        {
            Console.WriteLine("\t" +i);
        }
        isPrime = true;

    }
}
{   
    Console.WriteLine("Enter hello");
    string hello = Console.ReadLine();
    if ( hello == hello)
    {
        Console.WriteLine("Greetings!");
    }
    else
    {
        Console.WriteLine("Invalid Greeting");
    }
}






// MY code

{
    Console.WriteLine("Enter a number to check");
    string number;
    int i =int.Parse(Console.ReadLine());
    if(i <= 10)
    {
        Console.WriteLine("It lies in range of 1-10");
    }else if (i <= 20)
    {
        Console.WriteLine("It lies in range of 11-20");
    }else if (i <= 30)
    {
        Console.WriteLine("It lies in range of 21-30");
    }
    else if (i < 30)
    {
        Console.WriteLine("It is greater than 30 ");
    }else
    {
        Console.WriteLine("Please enter a valid number");
    }

}
        
// Corrected code 

    {
        Console.WriteLine("Enter a number to check:");

        // Corrected variable declaration
        int i;
        if (int.TryParse(Console.ReadLine(), out i))
        {
            if (i <= 10)
            {
                Console.WriteLine("It lies in the range of 1-10");
            }
            else if (i <= 20)
            {
                Console.WriteLine("It lies in the range of 11-20");
            }
            else if (i <= 30)
            {
                Console.WriteLine("It lies in the range of 21-30");
            }
            else
            {
                Console.WriteLine("It is greater than 30");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
}


//  program that takes a day of the week as input and prints a message based on whether it's a weekday or a weekend.



    {
        Console.WriteLine("Enter a day of the week:");

        // Read input day
        string inputDay = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitivity

        // Check if it's a weekday or weekend
        if (IsWeekend(inputDay))
        {
            Console.WriteLine("It's the weekend! Enjoy your day off.");
        }
        else if (IsWeekday(inputDay))
        {
            Console.WriteLine("It's a weekday. Time to get to work or school!");
        }
        else
        {
            Console.WriteLine("Invalid day. Please enter a valid day of the week.");
        }
    }

    static bool IsWeekend(string day)
    {
        return day == "saturday" || day == "sunday";
    }

    static bool IsWeekday(string day)
    {
        return !IsWeekend(day);
    }


*/

// program that takes two numbers and an arithmetic operator from the user 
// as input and performs the operation 

using System.Globalization;

{
    Console.Write("Enter the first number : ");
    double num1 = Convert.ToDouble(Console.ReadLine());


    Console.Write("Enter the second number :");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the arithmetic operator :");
    char operatorChar = Convert.ToChar(Console.ReadLine());

    double result = 0;


    switch (operatorChar)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            if (num2 !=0) // to avoid division by zero
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed. ");
                return;
            }
            break;
        default:
            Console.WriteLine("Error: Invalid operator . Please enter +,-,*,/");
                return;
    }
    Console.WriteLine($"Result : {num1} {operatorChar} {num2} = {result}");
}

// program that takes integer from user and calculate the sum of its digits 


{
    Console.WriteLine("Enter an integer : ");
    int num = Convert.ToInt32(Console.ReadLine());

    // calculating the sum of digits 
    int absNum = Math.Abs(num); // Ensures the number is non - negative for the loop 
    int sumDigits = 0;

    while (absNum > 0)
    {
        // extracting the last digit and adding it to the sum 
        sumDigits += absNum % 10;

        // removing the last digit from the number
        absNum /= 10;
    }
    Console.WriteLine($"Sum of digiits of {num}:{sumDigits}");
}