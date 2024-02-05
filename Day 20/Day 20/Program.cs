/*  OOPS
 
Concept of OOPs
- Class and Object 
- Methods
- Inheritence
- Polymorphism
- Abstraction
- Encapsulation


Class -- 1. Class is Blueprint / Template.
         2. Class in Not a Real World Entity.
         3. Class Do not occupy memory .

Object -- 1. Object is Instance of Class.
          2. Object is a real world entity.
          3. Object occupy memory.



Class and Objects

- Class has attribute and behaviour
- Based on class object has same Attribute and Behaviour.


Class Syntax -- [access modifier] - [class] - [identifier]
        
            ex-- public class Customer{
                    // fields , properties, methods and events
                  }



*/
using System;
using System.ComponentModel;
namespace Calculator
{
    public class Calculator
    {
        int num1; 
        int num2;
        int result;

        void add()
        {
            result = num1  + num2;
            Console.WriteLine(result);
        }
        void subtraction()
        {
            result = num1 - num2;
            Console.WriteLine(result);
        }
        
        public static void Main(string[] args)
        {
           // creating object
           Calculator obj=new Calculator();
            obj.num1 = 20;
            obj.num2 = 8;
            obj.add();
            obj.subtraction();

           Calculator obj1=new Calculator();
            obj1.num1=10;
            obj1.num2=5;
            obj1.add();
            obj1.subtraction();
        }
    }
}
