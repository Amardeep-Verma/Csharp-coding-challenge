/* using System;
class program
{
    public static void Main()
    {
        int a, b, i, Sum = 0;
        for (i = 1; i < 100; i++)
        {
            a = i % 3;
            b = i % 5;
            if (a == 0 || b == 0)
            {
                Console.Write("{0}\t", i);
                Sum = Sum + i;
            }
        }
        Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}",
                          Sum);
        Console.Read();
    }
} 


// keep taking numbers as input from user until  user enters a number which is multiple of 7

using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Enter a number: ");

            // Try to parse user input to an integer
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine(num);

                if (num % 7 == 0)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (true);

        Console.WriteLine("Thanks");
    }
}



// print multipliation table of any number
{
    Console.Write("Enter table no: ");
    int table = int.Parse(Console.ReadLine());

    for (int i = 1; i <=10; i++)
    {
        Console.WriteLine("{0} x {1} = {2}",table,i,i*table);
    }
}


// sum of n natural numbers

{
    Console.Write("enter any number: ");
    int num = int.Parse(Console.ReadLine());
    int sum   = 0;
    for(int i =1; i <= num; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine("The sum is {0}",sum);
}

// PRINT THE NUMBERS FROM 0 TO N , IF N IS GIVEN BY USER

{
    Console.Write("Enter any number:");
    int num = int.Parse(Console.ReadLine());

    int i = 0;
    while(i <= num)
    {
        Console.Write(i);
        i++;
    }
}

program that calculates the sum
 of all even numbers from 1 to 50 using a for loop:

*/


{
    int sum = 0;
    for (int i = 1; i <= 50; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine("sum of even numbers from 1 to 50 is {0}",sum);
}