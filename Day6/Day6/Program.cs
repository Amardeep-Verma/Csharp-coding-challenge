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
*/

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