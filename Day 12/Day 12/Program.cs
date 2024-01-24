// C# program that takes the user's name as input and prints a personalized greeting.

/*
{
    Console.Write("Please Enter your Name :");
    string str;
    str = Console.ReadLine();
    Console.WriteLine("Welcome {0}", str);

}

// Create a program that prompts the user to enter two integers and then displays their sum.

{   string str1, str2;
    int sum;
    Console.Write("Enter first integer : ");
    str1 = Console.ReadLine();
    Console.Write("Enter second integer : ");
    str2 = Console.ReadLine();
    sum = int.Parse(str1) + int.Parse(str2);
    Console.WriteLine("The sum of the netered integers is {0}", sum);

}



// LOOPs Questions Practice 

// 1. Print numbers from 1 to 10 using a 'for' loop.


{
    int i;
    for (i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}

// 2. Calculate the sum of numbers from 1 to 100 using a for loop.

{
    int sum = 0;
    for (int i = 1; i <=100;  i++)
    {
        sum += i;

    }
    Console.WriteLine("The sum of numbers from 1 to 100 is : "+ sum );
}

// 3. Print even numbers from 2 to 20 using a for loop.

{
    for (int i = 2; i <=20; i += 2)
    {
        Console.WriteLine(i);
    }
}

// 3. Calculate the product of numbers from 1 to 5 using a for loop.
{
    int product=1 ;
    for (int i = 1; i <= 5; i++)
    {
        product *= i;
    }
    Console.WriteLine("The product of numbers from 1 to 5 is " + product);

}

// 4. Find the factorial of a number usiung a for loop.

{

    Console.WriteLine("Enter a number to find its factorial: ");
    int number = int.Parse(Console.ReadLine());

    long factorial = 1;
     // using a for loop to calculate the factorial 
     for (int i = 1;i <= number; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("The factorial of " + number + "is: "+ factorial);




// 5 .  Check if a given number is prime using a for loop.
{

    Console.WriteLine("Enter a number to check if it is prime or not: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if ( num  % i == 0 )
            {
                Console.WriteLine(num + " is not a prime number");
                return ;
            }
        }
        Console.WriteLine(num > 1 ? num + " is a prime number.": num + " is not a prime number ");

    }




// 6  Print a multiplication table for a given number using a for loop

using System.ComponentModel;

{
    Console.WriteLine("Enter a number to generate its multiplication table :");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("Multiplication table for " + number + ":");

    // using a for loop to generate the multiplication table 

    for (int i = 1;i<=10 ;i++)
    {
        Console.WriteLine(number + "x" + i + "=" + (number * i));
        
    }
}

// 7. Reverse a given number using a while loop. 

{
    Console.WriteLine("Enter a number to reverse: ");
    int number = int.Parse(Console.ReadLine());

    int reversedNumber = 0;

    // using a while loop to reverse a number

    while (number > 0)
    {
        int digit = number % 10;  // get the last digit 
        reversedNumber = reversedNumber * 10 + digit;
        number /= 10;
    }
    Console.WriteLine("Reversed number : " + reversedNumber);
}



// 8. Calculate the average of 5 numbers using a while loop.

{
    Console.WriteLine("Enter 5 number to calculate their average:");

    int count = 0;
    int sum = 0;

    // using a while loop to input and calculate the sum 
    while (count < 5)
    {
        Console.Write("Enter number " + (count + 1) + ":");
        int number = int.Parse(Console.ReadLine());

        sum += number;
        count++;
    }
    // calculate and print the average 
    double average = (double)sum / 5;
    Console.WriteLine("The average of the entered number is: " + average);
}



// 9. find the sum of digits of a number using a do-while loop

{
    Console.WriteLine("Enter a number to find the sum of its digits: ");
    int number = int.Parse(Console.ReadLine());

    int originalNumber = number;
    int sum = 0;

    // using a do-while loop to find the sum of digits
    do
    {
        int digit = number % 10;    // get the last digit 
        sum += digit; // add the digit to the sum 
        number /= 10; // remove the last digit from the number
    } while (number > 0);
    Console.WriteLine("The sum of digits of " + originalNumber + "is:" + sum);


}



   10.  Print the pattern: *
        **
        ***
        ****
        *****
        using nested for loop
*/

{
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

