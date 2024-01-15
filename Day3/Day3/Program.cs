/*{namespace Day3

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string and prees enter");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

        }
    }
}

Console.WriteLine("Enter a string and press enter:");
int asciiValue = Console.Read();
Console.WriteLine("ASCII value is {0}:",asciiValue);
Console.ReadKey();
*/



// Enter any string and press enter : Denis
// You have entered Denis
// Enter any key and press enter : D
// ASCII value of the entered value is 68
/*
Console.WriteLine("Enter any string and press enter: ");
string name = Console.ReadLine();
Console.WriteLine("You have entered {0}", name);
Console.WriteLine("Enter any key and press enter:");
int asciivalue = Console.Read();
Console.WriteLine("ASCII value of the entered number is :{0}", asciivalue);
*/


/*Console Methods Explained
 1. Console.Write("text here") - Prints and keep the cursor on the same line
 2. Console.Writeline("text here") - Prints and puts the cursor in the next line.
 3. Console.Read() - Takes a single input of type string and it returns the ASCII value of that input.
 4. Console.ReadLine() - Takes a string or integer input and returns it as the Output value 
 5. Console.ReadKey() - Takes a single input of type string and it returns the Key Info.
*/