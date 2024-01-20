/*namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
                Console.WriteLine("The number is positive.");
            else if (number < 0)
                Console.WriteLine("The number is negative.");
            else
                Console.WriteLine("The number is zero.");
        }
    }
}

// CHECK IF A ALPHABET IS VOWEL

{
    Console.Write("Enter a character: ");
    char ch = char.Parse(Console.ReadLine());

    if ("aeiouAEIOU".IndexOf(ch) >= 0)
        Console.WriteLine($"{ch} is a vowel.");
    else
        Console.WriteLine($"{ch} is a consonant.");
}
*/

// CHECK GRADE OF STUDENT 

using System;

{
    Console.Write("Enter marks: ");
    int marks = int.Parse(Console.ReadLine());

    if (marks >= 90)
        Console.WriteLine("Grade: A");
    else if (marks >= 80)
        Console.WriteLine("Grade: B");
    else if (marks >= 70)
        Console.WriteLine("Grade: C");
    else if (marks >= 60)
        Console.WriteLine("Grade: D");
    else
        Console.WriteLine("Grade: F");
}



{
    Console.WriteLine("Choose a number (1-3): ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("You selected Option 1.");
            break;
        case 2:
            Console.WriteLine("You selected Option 2.");
            break;
        case 3:
            Console.WriteLine("You selected Option 3.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
            break;
    }



    {
        Console.WriteLine("Choose a number (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Option 1.");
                break;
            case 2:
                Console.WriteLine("You selected Option 2.");
                break;
            case 3:
                Console.WriteLine("You selected Option 3.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
                break;
        }
    }
}
In this simple program, the user is prompted to choose a number between 1 and 3. The program then uses a switch-case statement to perform different actions based on the user's choice. If the user enters a number outside the specified range, a default case handles the invalid input.




User
program to determine month name using switch case
ChatGPT
Certainly!Here's a simple C# program that uses a switch-case statement to determine the month name based on the user's input:

csharp
Copy code
using System;

class MonthNameProgram
{
    static void Main()
    {
        Console.Write("Enter the month number (1-12): ");
        int monthNumber = int.Parse(Console.ReadLine());

        string monthName;

        switch (monthNumber)
        {
            case 1:
                monthName = "January";
                break;
            case 2:
                monthName = "February";
                break;
            case 3:
                monthName = "March";
                break;
            case 4:
                monthName = "April";
                break;
            case 5:
                monthName = "May";
                break;
            case 6:
                monthName = "June";
                break;
            case 7:
                monthName = "July";
                break;
            case 8:
                monthName = "August";
                break;
            case 9:
                monthName = "September";
                break;
            case 10:
                monthName = "October";
                break;
            case 11:
                monthName = "November";
                break;
            case 12:
                monthName = "December";
                break;
            default:
                monthName = "Invalid month number";
                break;
        }

        Console.WriteLine($"The month is: {monthName}");
    }