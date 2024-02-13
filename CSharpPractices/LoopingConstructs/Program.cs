using HelperClass;

namespace LoopingConstructs
{
    public class Program
    {
        /// <summary>
        /// This is the main entry point of my Programme.
        /// </summary>
        /// <param name="args">args</param>
        static void Main(string[] args)
        {
            IfElse vote = new IfElse();


            IfElse sub = new IfElse();
            int minus = sub.SubNumbers(9, 3);
            Console.WriteLine(minus);

            IfElse add = new IfElse();
            int sum = add.AddNumbers(6, 8);
            Console.WriteLine(sum);

            MultiplicationClass Multiply = new MultiplicationClass();
            Console.Write("Enter first Number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int Multiplication = Multiply.MultiplyNumbers(number1, number2);
            Console.WriteLine("Multiplication result :"+ Multiplication);


            IfElse ifElse = new IfElse();   
            var isEven = ifElse.CheckEvenOdd(34);
            Console.WriteLine(isEven);
          
            IfElse Voting = new IfElse();
            var Eligible = Voting.Voting(5);
            Console.WriteLine(Eligible);

            IfElse Positive = new IfElse();
            int num = int.Parse(Console.ReadLine());
            var nPositive = Positive.CheckPositive(num);
            
            Console.WriteLine(nPositive);

            List<int> numbers = new List<int>();

            numbers.Select(x=> x).OrderDescending().ToList();

        }


        public int Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
