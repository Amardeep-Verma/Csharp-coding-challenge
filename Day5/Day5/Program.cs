using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3); //-5

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);  //false

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}",num);
            Console.WriteLine("num is {0}",num++);
            Console.WriteLine("num is {0}",num);

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}",--num);

            int result;

            result = num1+num2;
            Console.WriteLine("result of num1 + num2 is {0}",result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}",result);
            result = num1 / num2;
            Console.WriteLine("result of num 1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}",result);

            Console.ReadKey();
        }
    }
}
