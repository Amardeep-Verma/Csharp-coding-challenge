// C# program to demonstrate data types 
/*
using System;
namespace ValueTypeTest
{

    class DataTypes
    { 
        static void Main()
        {

            // declaring character 
            char a = 'G';

            
            int i = 89;

            short s = 56;

            // this will give error as number 
            // is larger than short range 
            // short s1 = 87878787878; 

            // long uses Integer values which 
            // may signed or unsigned 
            long l = 4564;

            // UInt data type is generally 
            // used for unsigned integer values 
            uint ui = 95;

            ushort us = 76;
            // this will give error as number is 
            // larger than short range 

            // ulong data type is generally 
            // used for unsigned integer values 
            ulong ul = 3624573;

            // by default fraction value 
            // is double in C# 
            double d = 8.358674532;

            // for float use 'f' as suffix 
            float f = 3.7330645f;

            // for float use 'm' as suffix 
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
        }
    }
}
*/


// IMPLICIT AND EXPLICIT CONVERSION

{   //explicit coversion

    double myDouble = 13.37;
    int myInt;

    // cast double into int
    myInt = (int)myDouble;
    Console.WriteLine(myInt);  //13

}


{
    //implicit conversion
    int num = 12345678;
    long bignum = num;

    float myFloat = 13.37f;
    double myNewDouble = myFloat;
    Console.WriteLine();
}

{
    // type conversion
    double myDouble = 13.37;
    string myString = myDouble.ToString(); // "13.37"
    float myFloat = 13.37f;
    string myString1 = myFloat.ToString();
    Console.WriteLine(myFloat);
}

{
    bool sunIsShining = true;
    if (sunIsShining == true );
    Console.WriteLine(sunIsShining);
}

// PARSING STRING TO INTEGER

{
    string myString = "15";
    string mySecondString = "13";
    int num1=Int32.Parse(myString);
    int num2=Int32.Parse(mySecondString);
    int resultInt = num1 + num2;
    string result = myString + mySecondString;
    Console.WriteLine(resultInt);
}

//Assignment -- Parse the string variables from below into the correct datatypes:

{
    string stringForFloat = "0.85"; // datatype should be float
    string stringForInt = "12345"; // datatype should be int

    int i = Int32.Parse(stringForInt);
    float f = float.Parse(stringForFloat);

    System.Console.WriteLine("Int = {0}, Float = {1}", i, f);
}

//STRING MANIPULATION

{
    //defining few variables
    int age = 31;
    string name = "Rishu";
    string job = "student";

    // Method 1 : String Concatenation
    Console.WriteLine("String Concatenation");
    Console.WriteLine("Hello my name is " + name + ",I am " + age + " years old");


    // Method 2 : String Formatting.
    Console.WriteLine("String Formatting");
    Console.WriteLine("Hello my name is {0} , I am {1} years old. I am a {2}", name ,age,job);

    // Method 3 : String Interpolation.
    // string Interpolation uses $ at the start which will allow us to write 
    // our variables like this {variableName}

    Console.WriteLine("String Interpolation");
    Console.WriteLine($"Hello my name is {name}, I am {age} years old",name, age);
        
    // Method 4 : Verbatim strings.

}

/*
  Various String Methods

 1. SubString(int32) - is used to get the Substring from the string , starting from the specified index.
 2. ToLower() - is used to convert the string to lowercase.
 3. ToUpper() - is used to convert the string to uppercase.
 4. Trim() - is used to trim all leading and trailing white space from the string.
 5. IndexOf() - is used to get the first occurence of the string or character inside the string.
 6. IsNullOrWhiteSpaces - returns true if the string is either null or is blank else it returns false.



{
    string firstName = "Rishu";
    string lastName = "Verma";
    string fullName= string.Concat("",firstName, lastName,"");
    Console.WriteLine(firstName.Substring(2)); // shu
    Console.WriteLine(firstName.ToLower());
    Console.WriteLine(firstName.ToUpper());
    Console.WriteLine(fullName.Trim());
    Console.WriteLine(firstName.IndexOf('e'));
    Console.WriteLine(String.IsNullOrWhiteSpace(firstName));
}

// String.Format :
 1. In C# the String.Format method is used to insert the object or varibale 
    value inside ant string
 2. With the String.Format we can replace the value in the specified format.
 3. Syntax : String.Format("any string{index}", object);

Example:
    var name = "Rishu"
    String.Format("My name is {0}", name); //Here the string name will be 
                                           // replaced at index {0} in the string and the output will be "My name is Rishu".
*/

// string s1 = "this is a \"string\" with \n a backslash \\ and and colon :";
// Console.WriteLine(s1);


/*{


    string myName;
    Console.WriteLine("enter your name");
    myName = Console.ReadLine();
    string myNameUpperCase = String.Format("Upper case : {0}", myName.ToUpper());
    string myNameLowerCase = String.Format("Lower case : {0}",myName.ToLower());
    string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
    string myNameSubString = String.Format("Substring value : {0}", myName.Substring(0, 5));

    Console.WriteLine(myNameUpperCase);
    Console.WriteLine(myNameLowerCase);
    Console.WriteLine(myNameTrimmed);
    Console.WriteLine(myNameSubString);
    Console.ReadKey();

}
*/


/*
{
    Console.WriteLine("Enter the string here: ");
    //Read first input string.
    string input= Console.ReadLine();

    Console.Write("Enter a character to search: ");
    //Read the character input to search.

    char searchInput = Console.ReadLine()[0];
    //Gets the Index of the character from the string.
    int searchIndex = input.IndexOf(searchInput);
    //Prints the Index as a search result on console.
    Console.WriteLine("Index of character {0} in string is {1}", searchInput,searchIndex);


    Console.Write("Enter first name: ");
    //Read the first name
    string firstName=Console.ReadLine();
    Console.Write("Enter last name: ");
    //Read the last name 
    string lastName=Console.ReadLine();

    //Concatenate the firstName and lastName variable and assign that to fullName variable.
    string fullName=string.Concat(firstName," ", lastName);
    Console.WriteLine("Your full name is {0}",fullName);
}


// USING THE VAR KEYWORD

{
    var number = 0; //int
    var text = "Text";//string
    var isTrue = false; //boolean

}
*/

