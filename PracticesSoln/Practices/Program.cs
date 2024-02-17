using System;
using System.Buffers.Text;
using System.ComponentModel;

namespace Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("GRADE CALCULATOR");
            Console.WriteLine("**************************");
            Console.Write("Enter your marks:");
            Grade grade = new Grade();
            int num1 = int.Parse(Console.ReadLine());

            var checkGrade = grade.Grading(num1);
            Console.WriteLine(checkGrade);



            Console.WriteLine("**************************");
            Console.WriteLine("TICKET COUNTER");
            Console.WriteLine("**************************");
            Ticket ticket = new Ticket();
            Console.Write("Enter your  age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the movie time:");
            int movieTime = int.Parse(Console.ReadLine());
            var TicketPrice = ticket.CalculatePrice(age, movieTime);
            Console.WriteLine("Your ticket price is " + TicketPrice + "$");


            /*Create a tax calculator program that takes a person's income as input and calculates their 
             * tax based on the following rules:

                Income up to $10,000 is not taxed.
                Income between $10,001 and $50,000 is taxed at 10%.
                Income above $50,000 is taxed at 20%.  */


            Console.WriteLine("**************************");
            Console.WriteLine("TAX CALCULATOR");
            Console.WriteLine("**************************");
            TaxCalc taxCalc = new TaxCalc();
            Console.Write("Enter your income: ");
            int income = int.Parse(Console.ReadLine()); 
            var tax = taxCalc.income(income);
            Console.WriteLine("Your tax is "+ tax + "%");


            Console.WriteLine("");

            //Design a program that calculates the total cost of items purchased, applying discounts based on the quantity purchased.The rules are:

            // No discount for buying less than 5 items.
            // 10 % discount for buying 5 - 10 items.
            // 20 % discount for buying 11 or more items.

            Console.WriteLine("**************************");
            Console.WriteLine("DISCOUNT CALCULATOR");
            Console.WriteLine("**************************");
            discount Discount = new discount();
            Console.Write("Enter number of items purchased:");
            int items = int.Parse(Console.ReadLine());
            var dis = Discount.item(items);
            Console.WriteLine("Your discount is "+ dis + "%");




            // Underweight: BMI less than 18.5
            // Normal weight: BMI 18.5 - 24.9
            // Overweight: BMI 25 - 29.9
            // Obese: BMI 30 or greater

            Console.WriteLine("**************************");
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("**************************");
            bmi BmI = new bmi();
                Console.WriteLine("Enter your body mass index");
                float index = float.Parse(Console.ReadLine());
                var BmIndex = BmI.BodyMassIndex(index);
                Console.WriteLine("Your BMI is " + BmIndex);


            // factorial
            {
                int i, number, fact;
                Console.WriteLine("Enter the Number");
                number = int.Parse(Console.ReadLine());
                fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("\nFactorial of Given Number is: " + fact);
            }



            {
                int resultAdd = Calculator.Add(5, 3);
                Console.WriteLine("Addition result: " + resultAdd);

                int resultSubtract = Calculator.Subtract(8, 3);
                Console.WriteLine("Subtraction result: " + resultSubtract);

                int resultMultiply = Calculator.Multiply(4, 6);
                Console.WriteLine("Multiplication result: " + resultMultiply);

                double resultDivide = Calculator.Divide(10, 2);

                
                Console.WriteLine("Division result: " + resultDivide);


                int n1 = 0, n2 = 1, n3, i, number;
                Console.Write("Enter the number of elements:");
                number = int.Parse(Console.ReadLine());
                Console.Write(n1+""+n2+"");
                for(i=2;i<number; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3+" ");
                    n1= n2;
                    n2 = n3;
                }



            }

        }


    }

}
