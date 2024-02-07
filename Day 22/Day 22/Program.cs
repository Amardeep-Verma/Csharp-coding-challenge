// Loops 

/*

// for loop to compute sum of first n natural numbers
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

{
    Console.WriteLine("Enter number:");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum=0;
    for (int i = 1;i <= number; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Sum of {number} is {sum}");
}



// for loop with multiple initialization and iterator expression

{
    for (int i = 0,j = 0; i+j <= 5; i++ , j++){
        Console.WriteLine($"i={i},j={j}");

    }
}



// for loop without initialization and iterator statement
{
    int i = 1;
    for (; i <= 5;)
    {
        Console.WriteLine($"C# For Loop:Iteration {i}");
        i++;
    }
}


// infinite loop
{
    for (int i = 1; i > 0; i++)
    {
        Console.WriteLine(i);
    }
}



// nested for loop
{
    for (int i = 1; i <= 3; i++)
    {
        for (int j = 1; j <= 3; j++)
        {
            Console.WriteLine(i+" "+j);
        }
    }
}

*/

    {
        int count = 10;
        while (count > 0)
        {
            Console.WriteLine(count);
            count--;
        }
        Console.WriteLine("Blast off!");
    }


{
    int sum = 0;
    int i = 1;
    while (i <= 10)
    {
        sum += i;
        i++;
    }
    Console.WriteLine("Sum of numbers 1 to 10: " + sum);
}


{
    int num = 2;
    while (num <= 20)
    {
        Console.WriteLine(num);
        num += 2;
    }
}

{ 

int number = 5;
int factorial = 1;
int i = 1;
while (i <= number)
{
    factorial *= i;
    i++;
}
Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }