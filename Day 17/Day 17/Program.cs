// program to find the minimum range of values for decimal,float and double datatype
/*
{
    Console.WriteLine("The Minimum Range of the Decimal Data " +
                      "Type is : {0} ", Decimal.MinValue);
    Console.WriteLine("The Minimum Range of the Float Data " +
                      "Type is : {0} ", Single.MinValue);
    Console.WriteLine("The Minimum Range of the Decimal Data " +
                      "Type is : {0} ", Double.MinValue);
    Console.WriteLine("Exponent Form : The Minimum Range of Decimal " +
                      "Data Type  is : {0:E}", Decimal.MinValue);
    Console.WriteLine("Exponent Form : The Minimum Range of Float " +
                      "Data Type  is : {0:E}", Single.MinValue);
    Console.WriteLine("Exponent Form : The Minimum Range of Double " +
                      "Data Type  is : {0:E}", Double.MinValue);
}


// program to find maximum range of values for decimal , float and double datatype
{
    Console.WriteLine("The Maximum Range of the Decimal " +
                      "Data Type is : {0} ", Decimal.MaxValue);
    Console.WriteLine("The Maximum Range of the Float " +
                      "Data Type is : {0} ", Single.MaxValue);
    Console.WriteLine("The Maximum Range of the Decimal " +
                      "Data Type is : {0} ", Double.MaxValue);
    Console.WriteLine("Exponent Form : The Maximum Range of Decimal " +
                      "Data Type  is : {0:E}", Decimal.MaxValue);
    Console.WriteLine("Exponent Form : The Maximum Range of Float " +
                      "Data Type  is : {0:E}", Single.MaxValue);
    Console.WriteLine("Exponent Form : The Maximum Range of Double " +
                      "Data Type  is : {0:E}", Double.MaxValue);
    Console.ReadLine();
}



//Program to Check Whether the Given Number is a Prime number if so then 
Display its Largest Factor

{
    Console.Write("Enter a Number : ");
    int num;
    num = Convert.ToInt32(Console.ReadLine());
    int k;
    k = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            k++;
        }
    }
    if (k == 2)
    {
        Console.WriteLine("Entered Number is a Prime Number and " +
                          "the Largest Factor is {0}", num);
    }
    else
    {
        Console.WriteLine("Not a Prime Number");
    }
    Console.ReadLine();
}



{
    int num, sum = 0, r;
    Console.WriteLine("Enter a Number : ");
    num = int.Parse(Console.ReadLine());
    while (num != 0)
    {
        r = num % 10;
        num = num / 10;
        sum = sum + r;
    }
    Console.WriteLine("Sum of Digits of the Number : " + sum);
    Console.ReadLine();

}

{
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        Console.WriteLine("Number is positive");
    }
    else if (number == 0)
    {
        Console.WriteLine("Number is 0");
    }
    else
    {
        Console.WriteLine("Number is negative");
    }
}

{
    leapyear obj = new leapyear();
    obj.readdata();
    obj.leap();
}
int y;
public void readdata()
{
    Console.WriteLine("Enter the Year in Four Digits : ");
    y = Convert.ToInt32(Console.ReadLine());
}
public void leap()
{
    if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
    {
        Console.WriteLine("{0} is a Leap Year", y);
    }
    else
    {
        Console.WriteLine("{0} is not a Leap Year", y);
    }
    Console.ReadLine();
}



using System;
using System.Globalization;
namespace vowel
{
    class consonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch =='i' || ch == '0' || ch== 'u')
            {
                Console.WriteLine($"{ch} is a vowel ");
              
            }
            else
            {
                Console.WriteLine("It is consonant");
            }
        }
    }
}
*/
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        while (true)
        {
            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter the operator (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after reading the operator.

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result = 0;

            // Perform the calculation based on the operator
            switch (operation)
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
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /).");
                    continue;
            }

            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

            Console.Write("Do you want to perform another calculation? (y/n): ");
            char continueChoice = Console.ReadKey().KeyChar;

            if (continueChoice != 'y')
            {
                break;
            }

            Console.WriteLine(); // Move to the next line after reading the continue choice.
        }
    }
}
