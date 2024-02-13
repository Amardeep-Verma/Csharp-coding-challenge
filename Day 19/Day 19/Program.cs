/*{
    Console.WriteLine("enter a number : ");
    int num = int.Parse(Console.ReadLine());
    if(num % 2 == 0)
    {
        Console.WriteLine("It is even ");
    }else if(num % 2 != 0) {
        Console.WriteLine("it is odd");

    }
    else
    {
        Console.WriteLine("Inavlid input");
    }
}


// find largest of two
{
    Console.Write("Enter first number");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second number");
    int num2 = int.Parse(Console.ReadLine());   
    if(num1 == num2)
    {
        Console.WriteLine("Both are equal");
    }else if (num1 > num2)
    {
        Console.WriteLine($"{num1} is greater than {num2}");

    }else if (num2 > num1)
    {
        Console.WriteLine($"{num2} is greater than {num1}");
    }
}


// MATH CLASS

{
    int a = Math.Max(34,345);
    Console.WriteLine(a);
    int b = Math.Min(12, 262);
    Console.WriteLine(b);
    double c = Math.Sqrt(36);
    Console.WriteLine(c);
    int d = Math.Abs(-39);
    Console.WriteLine(d);

    string hello = "my name is rishu";
    Console.WriteLine(hello.Length);
    Console.WriteLine(hello.ToLower());

    Console.WriteLine(hello + "You are nice");
    
    Console.WriteLine(string.Concat(hello,"You are nice"));

    string name = Console.ReadLine();
    string candies = Console.ReadLine();
    Console.WriteLine();

}



//Functions

using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

static void Greet()
{
    Console.WriteLine("Good morning");
}

{
    Greet();
    Greet();
}

static float Average(float a , float b , float c)
{
    float sum = a +b +c;
    return sum / 3;

 
}
{
    Console.WriteLine(Average(3, 3, 3));
    Console.WriteLine(Average(10, 20, 30));

    float temp = Average(9, 3, 3);
    Console.WriteLine(temp);
}

static int add(int a, int b)
{
     int sum = a +b;
    return sum;
}

{
    Console.WriteLine(add(5,5));
}

// programs to reverse a string 

{
    Console.Write("Enter a string:");
    string originalString = Console.ReadLine();
    string reverseString = string.Empty;
    for (int i = originalString.Length - 1; i >= 0; i--)
    {
        reverseString += originalString[i];
    }
    Console.Write($"Reverse String is : {reverseString}");
}

// volume of cube

{
    Console.Write("Enter side: ");
    decimal Side = Convert.ToDecimal(Console.ReadLine());
    decimal Volume = Side * Side * Side;
    Console.WriteLine("Volume of cube = " + Volume);
}


// pattern printing 

{
    Console.WriteLine("Enter number of rows:");
    int row = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine("\n");
    }
}
 */