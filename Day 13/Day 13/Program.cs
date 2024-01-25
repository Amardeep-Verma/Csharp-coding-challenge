// program that takes a user-input string and uses int.Parse to convert it to an integer.

{
    Console.Write("Enter a number: ");
    string userInput = Console.ReadLine();

    if (int.TryParse(userInput, out int result))
    {
        Console.WriteLine($"Successfully parsed: {result}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

{
    Console.Write("Enter a number: ");
    string userInput = Console.ReadLine();

    int result = Convert.ToInt32(userInput);

    Console.WriteLine($"Converted using Convert.ToInt32: {result}");
}

