//Program to find the minimum Range of Values for decimal , float and double datatype.


/* namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.ReadLine();
        }
    }
}


// Program to Swap two Numbers
{
    int num1, num2, temp;
    Console.Write("\nEnter the First Number : ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("\nEnter the Second Number : ");
    num2 = int.Parse(Console.ReadLine());
    temp = num1;
    num1 = num2;
    num2 = temp;
    Console.Write("\nAfter Swapping : ");
    Console.Write("\nFirst Number : " + num1);
    Console.Write("\nSecond Number : " + num2);
    Console.Read();
}


{
    int temperature = 25;

    if (temperature <10)
    {
        Console.WriteLine("Take the coat");
    }
    if (temperature == 10)
    {
        Console.WriteLine("It's 10 degrees");
    }
    if (temperature > 10)
    {
        Console.WriteLine("Cozy and warm");
    }
}
 


{
    Console.WriteLine("Enter Today's Temperature");
    string temperature = Console.ReadLine();
    int numTemp = Int32.Parse(temperature);
    if (numTemp < 10)
    {
        Console.WriteLine("Take the coat");
    }
    if (numTemp == 10)
    {
        Console.WriteLine("Pants and Pull Over should be fine");
    }
    if (numTemp > 10)
    {
        Console.WriteLine("Shorts are enough today");
    }
}


{
    Console.WriteLine("Enter your age");
    string age = Console.ReadLine();
    int ageInt = Int32.Parse(age);
    if (ageInt>=18)
    {
        Console.WriteLine("you can vote");
    }
    if (ageInt<18)
    {
        Console.WriteLine("You cannot vote ");
    }
    
}        The above program is not the proper approach

{
    Console.WriteLine("Enter your age");
    string age = Console.ReadLine();
    int ageInt = int.Parse(age);
    if(ageInt >=18)
    {
        Console.WriteLine("You can vote");
    }
    else
    {
        Console.WriteLine("You cannot vote");
    }
}


// TRY PARSE METHOD -- coverting strings into numeric data types
// by using the TryParse() method we can convert a string like "128" into a numeric data type like an integer

// TryParse() often gets used when the user submits input

// 1. We need a string
{
    string numberAsString = "128";
    int parsedValue;
    bool success = int.TryParse(numberAsString, out parsedValue);
    // The returned boolean is true when parsing was successful
    if (success)
        Console.WriteLine("Parsing successful-number is" + parsedValue);
    else Console.WriteLine("Parsing failed");
}
*/

// float.TryParse

{
    string numberAsString = "128";
    float parsedValue;

    bool success = float.TryParse(numberAsString, out parsedValue);
    if (success)
        Console.WriteLine("Parsing successful- number is ", parsedValue);
    else
        Console.WriteLine("Parsing failed");
}