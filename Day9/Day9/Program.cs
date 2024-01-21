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

{
   
    int temperature = -5;

    //Our result
    string stateOfMatter;

    //Is the Temperature below 0 Degree Celsius?
    if (temperature < 0)
    {
        stateOfMatter = "solid";
    }
    //Is the Temperature higher than 100 Degree Celcius?
    else if (temperature > 100)
    {
        stateOfMatter = "gas";
    }
    //In all other Cases it must be liquid.
    else
    {
        stateOfMatter = "liquid";
    }

    Console.WriteLine("State of Matter is {0}", stateOfMatter);

    //The same result can be achieved by this
    //The enhanced Version of the If-Else-Statement from above
    stateOfMatter = temperature < 0 ? "solid" : (temperature > 100 ? "gas" : "liquid");

    Console.WriteLine("State of Matter is {0}", stateOfMatter);

    //To make sure the Console keeps open
    Console.Read();

}

{
    int inputTemperature = 0;
    string temperatureMessage = string.Empty;
    string inputValue = string.Empty;

    // takes input from console
    Console.Write("Enter the current Temperature");
    inputValue = Console.ReadLine();

    // validate the input as valid input integer value
    bool validInteger = int.TryParse(inputValue, out inputTemperature);

    if (validInteger)
    {
        // if is valid integer then it will check for the condition using nested ternary operator
        temperatureMessage = inputTemperature <= 15 ?
            //true
            "it is too cold here" :
            //false
            (inputTemperature >= 16 && inputTemperature <= 28) ?
            // true 
            "It is cold here" :
            //false
            inputTemperature > 28 ?
            //true
            "it is hot here " :
            //false
            "";
        Console.WriteLine(temperatureMessage);
    }
    else
    {
        Console.WriteLine("Not a valid Temperature");
    }

    }
