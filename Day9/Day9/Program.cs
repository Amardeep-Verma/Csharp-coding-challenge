/* using System;

namespace IfStatementsChallenge2
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Rishu";

        static void Main(string[] args)
        {
            CheckHighscore(250, "Amar");
            CheckHighscore(315, "John");
            CheckHighscore(400, "Aditya");
            
        }
        public static void CheckHighscore (int score , string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;


                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now hold by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken . It is still " + highscore + "and held by " + highscorePlayer);
            }
        }
    }
}


// ENHANCED IF STATEMENT

// condition ? first_expression : second_expression;
// condition has to be either true or false 
// The conditional operator is right - associative.
// The expression a ? b : c? d : e
// is evaluated as a ? b : (c ? d :e ),
// not as ( a? b :c ) ? d : e.
// The condition operator cannot b eoverloaded.

// in celsius

{
    int temperature = -5;
    string stateOfMatter;

    if (temperature > 0)
        stateOfMatter = "solid";
    else
        stateOfMatter = "liquid";

    Console.WriteLine("State of matter is {0}",stateOfMatter);


*/

{
    int temperature;
    string stateOfMatter;

    temperature = 30;

    stateOfMatter = temperature < 0 ? "solid" : "liquid";
    Console.WriteLine("State of Matter is {0}",stateOfMatter);
   
    
}