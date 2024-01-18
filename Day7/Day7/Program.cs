/* C# int.Parse Method

 Convert a string representation of number to an integer, using the int.Parse
 method in C#. If the string cannot be converted , then the int.Parse method returns an exception.

Let's say we have a string representation of a number:
     string myStr = 200;
Now to convert it into integer , use the int.Parse(). It will get converted.
     int.Parse(myStr);

using System;
class Program
{
    static void Main(string[] args)
    {
        int result;
        string myStr = "ab0";
        result = int.Parse(myStr);
        Console.WriteLine("String is a numeric representation: "+result);
    }
}

If the string cannot be converted, then the int.TryParse
method returns false i.e. a Boolean value, whereas int.Parse returns an exception.

{
    bool result;
    int a;
    string myStr = "120";
    result = int.TryParse(myStr, out a);
    Console.WriteLine("String is a numeric representation:" +result);
}


{
    Console.WriteLine("What's the temperature like?");
    string temperature = Console.ReadLine();
    int numTemp;
    int number;
    bool userEnteredANumber = int.TryParse(temperature, out number); ;

    if (userEnteredANumber)
    {
        numTemp = number;
    }else
    {
       numTemp = 0;
        Console.WriteLine("Value entered,was no number. 0 set as temperature");
    }
    if(numTemp < 20)
    {
        Console.WriteLine("Take the coat ");
    }else if(numTemp == 20)
    {
        Console.WriteLine("Pants and Pull over should be fine");

    }else if (numTemp > 30)
    {
        Console.WriteLine("It's super hot!");

    }
    else
    {
        Console.WriteLine("Shorts are enough today");
    }
    Console.Read();
}


// PROGRAM TO CHECK EVEN OR ODD NUMBER
{
    Console.WriteLine("Enter any number");
    if (int.TryParse(Console.ReadLine(), out int number))


        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


// NESTED IF 

{
    bool isAdmin = false;
    bool isRegistered = true;
    string userName = "";
    Console.WriteLine("Please enter your username");
    userName = Console.ReadLine();

    if (isRegistered)
    {
        Console.WriteLine("Hi there, registered user");
        if(userName != "")
        {
            Console.WriteLine("Hi there. " + userName);
            if(userName.Equals("Admin"))
            {
                Console.WriteLine("Hi there, Admin");
            }

        }
    }
}



// Same same but different

{
    bool isAdmin = false;
    bool isRegistered = true;
    string userName = "";
    Console.WriteLine("Please enter your username");

    userName = Console.ReadLine();
    if (isRegistered && userName != "" && userName.Equals("admin"))
    {
        Console.WriteLine("hi there , registered user");
        Console.WriteLine("Hi there ," + userName);
        Console.WriteLine("Hi there , Admin");
    }
    if(isAdmin || isRegistered)
    {
        Console.WriteLine("you are logged in");
    }
}
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3");
            }
            if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
