/*
    

// 1 -100 how many even and how many odd 



using System.ComponentModel.Design;

{

    int even = 0;
    int odd = 0;
    int counter = 0;

    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            even = i;
            //Console.WriteLine(even);
            counter++;
        }

    }

    Console.WriteLine($"Total Even Numbers are {counter}");
}

// Write a C# Sharp program to compute the sum of the two numerical values. If the two
// values are the same, return triple their sum.

{
    int result;
    Console.Write("Enter first number:");
    int num1 = int.Parse( Console.ReadLine() );
    Console.Write("Enter second number:");
    int num2 = int.Parse( Console.ReadLine() ); 
    if (num1 != num2)
    {
        result = num1 + num2;
        Console.WriteLine(result);
    }else if(num1 == num2)
    {
        result = (num1 + num2 )* 3;
        Console.WriteLine(result);
    }
    
}

{
    int num1, num2;
    Console.Write("Enter an integer:");
   
    num1= int.Parse( Console.ReadLine() );
    Console.Write("Enter another integer:");
    num2 = int.Parse( Console.ReadLine() );

    if ( num1 == 30 || (num1 + num2 == 30) || num2== 30)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}



{
    int num;
    Console.Write("Enter a number:");
    num = int.Parse(Console.ReadLine());
    if(num % 3 == 0 || num % 7 == 0)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}


{
    char ch1,ch2,ch3;
    Console.Write("Enter first letter:");
    ch1= char.Parse(Console.ReadLine());
    Console.Write("Enter second letter:");
    ch2= char.Parse(Console.ReadLine());
    Console.Write("Enter third letter:");
    ch3= char.Parse(Console.ReadLine());

    Console.WriteLine($"After reversing the letters are {ch3} {ch2} {ch1}");
}

// perimeter of circle

{
    double radius,perimeter;
    Console.Write("Enter radius of circle:");
    radius = double.Parse(Console.ReadLine());
    perimeter = 3.14 * radius * radius;
    Console.WriteLine("Perimeter of circle :" + perimeter);

}



{
    Console.Write("Enter number between 0 to 1000");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num <0 || num >1000)
    {
        Console.WriteLine("Number is out of range");
    }
    else
    {
        Console.WriteLine(num);
    }
}


using System.Data;

{
    int row, columns;
    
    Console.Write("Enter no of rows:");
    row = int.Parse(Console.ReadLine());
    Console.Write("Enter no of columns:");
    columns = int.Parse(Console.ReadLine());
   

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

    }
}



    
    {
        int row, i, j;
        Console.Write("Enter the number of rows: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        for (i = 1; i <= row; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }
    }


{
    int row, i, j;
    Console.Write("Enter the number of rows: ");
    row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    for (i = row; i >= 1; i--)
    {
        for (j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}



    {
        int n ;
        Console.WriteLine("enter no of rows");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }



{
    Console.WriteLine("Enter no of rows");
    int n = int.Parse(Console.ReadLine());

    for (int i = n; i >= 1; i--)
    {
        for (int j =1; j<= n-i;j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

{
    int n;
    Console.WriteLine("Enter no of rows:");
    n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = n; i >= 1; i--)
    {
        for (int j = 1; j <= n - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}





using System.Runtime.Intrinsics.Arm;

{
    int n, i, count = 0;
    Console.Write("Enter a number:");
    n = int.Parse(Console.ReadLine());

    for(i=1;i<=n;i++) {
    if(n %i == 0)
        {
            count++;
        }
    }
    if (count== 2)
    {
        Console.WriteLine($"{n} is prime .");
    }
    else
    {
        Console.WriteLine("Not prime");
    }
}

// Palindrome Number, Armstrong Number
// Armstrong Number eg; 23 = (2)*2 + (3)*2

{
    int num, temp, revNum = 0,remainder;
    Console.Write("Enter number to check if its palindrome or not :");
    num = int.Parse(Console.ReadLine());
    temp = num;
    while(num > 0)
    {
        remainder = num % 10;
        revNum = revNum * 10 + remainder;
        num  = num / 10;

    }
    if(revNum == temp )
    {
        Console.WriteLine($"{temp} is palindrome number.");

    }
    else
    {
        Console.WriteLine($"{temp} is not a palindrome number.");
    }
}
*/
{
    Console.Write("Enter a number:");
    int number = int.Parse(Console.ReadLine());

    int originalNumber = number;
    int sum = 0;
    int numberOfDigits = 0;

    while (number != 0)
    {
        number /=10;
        numberOfDigits++;
    }
    number = originalNumber;
    while (number != 0)
    {
        int digit = number %10;
        sum += (int)Math.Pow(digit, numberOfDigits);
        number /=10;
    }
    if ( sum == originalNumber )
    {
        Console.WriteLine($"{originalNumber} is Armstrong Number.");
    }
    else
    {
        Console.WriteLine($"{originalNumber} is Not an Armstrong Number.");
    } 
}
