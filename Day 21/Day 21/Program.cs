/*namespace Day_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

*/


using Day_21;

{
    // a class in C# is a blueprint for creating objects.
    // it defines a set of properties (data attributes)
    // and methods (functions) that an object of that class will have

    Car audi = new Car();
    audi.Drive();

    Car bmw = new Car();
    bmw.Drive();

    Console.WriteLine("Press 1 to stop the car");
    string userInput = Console.ReadLine();
    if(userInput == "1")
    {
        audi.Stop();
    }
    else
    {
        Console.WriteLine("Car drives indefinetely");
    }
}