

namespace LoopingConstructs
{
    public class IfElse
    {
        /// <summary>
        /// This methods take an input of number and checks if its even or odd
        /// </summary>
        /// <param name="number">Any Positive number</param>
        /// <returns></returns>
        public string CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Number is Even";
            }
            else
            {
                return "Number is Odd";
            }
        }

        public string Voting(int number)
        {
            if (number >= 18)
            {
                return "You can vote";
            }
            else
            {
                return "You cannot vote";
            }
        }

        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

     


        public void CheckCharType(char inputChar)
        {
            if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u') 
            {
                Console.WriteLine($"{inputChar} is a vowel.");
            }
            else
            {
                Console.WriteLine($"{inputChar} is a consonant.");
            }
        }


        public int SubNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        public string CheckPositive(int number)
        {
            if (number > 0)
            {
                return "Number is Positive";
            }
            else if(number == 0)
            {
                return "Number is zero";
            }
            else
            {
                return "Number is zero";
            }
        }

    }

}
