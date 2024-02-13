/* namespace Day_14
{
    class student
    {
        public string name;
        public int age;
        public int marks;
        
        public void detail()
        {
            Console.WriteLine("Name = {0} Age = {1} Marks = {2}",name,age,marks);
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
            student std = new Day_14.student();
            std.age = 21;
            std.marks = 10;
            std.name = "Rishu";

            std.detail();
        }
    }
}




{
    Console.WriteLine("Enter your age :");
    int age = int.Parse(Console.ReadLine());
    string message = age >= 18 ? "Adult" : " not adult ";
    Console.WriteLine(message);
}




 // program to calculate sum of all even no from 1 to 50
{
    int sum = 0;
    for (int i = 1; i <= 50; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
        
    }
    Console.WriteLine("Sum of even no from 1 to 50 {0}", sum);
}

*/


{
    int number;
    Console.Write("Enter a number: ");
    number = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine($"Multiplication table for {number}:");
    for( int i = 0; i <=10; i++)
    {
        Console.WriteLine($"{number}x{i} = {number * i}");
    }
}
