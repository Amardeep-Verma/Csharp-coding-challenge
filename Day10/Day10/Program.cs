// LOOPS

/* 
        Types of Loops
    1. for loop
    2. while loop (check then go)
    3. do while loop (do first then check )
    4. foreach loop (run through array or list)

        # for loop
    Syntax -- for(start value;condition ; increment) {
                    // code body
                }

        # While Loop
     Syntax -- counterVariable = 0;
                while(condition){
                    //execute your code
                counterVariable++;
                    } 

        # Do While Loop
      Syntax -- counterVariable = 0;
                 do{
                    //execute your code
                  counterVariable++;
                    }while(condition)

        # foreach loop
        - runs through an array
        - only as long as there is content

 


// for loops

{
    for (int counter=0;counter < 10; counter++)
    {
        Console.WriteLine(counter);
    }
}


{
    for (int i = 20; i < 35; i++)
    {
        Console.WriteLine(i + " is lower than 50");
        
    }
    Console.WriteLine("For loop is done");
}

  DO WHILE LOOP
 
In C#, the do-while loop is a control flow structure that 
repeatedly executes a block of code as long as a specified 
condition is true. Unlike the while loop, the do-while loop guarantees
that the block of code is executed at least once, even if the condition is initially false.

SYNTAX 
do
{
    // Code to be executed
} while (condition);


The steps of the do-while loop are as follows:

The block of code within the do statement is executed.
After the execution of the code in the do block, the loop checks the specified condition in the while statement.
If the condition is true, the loop goes back to step 1 and repeats the process.
If the condition is false, the loop exits, and the program continues with the next statement after the do-while loop.




    {
        int count = 0;

        do
        {
            Console.WriteLine("Count: " + count);
            count++;
        } while (count < 5);
            Console.WriteLine("Loop is over");
}


{
    int lengthOfText = 0;
    string wholeText = "";
    do
    {
        Console.WriteLine("Please enter the name of a friend");
        string nameOfAFriend = Console.ReadLine();
        int currentLength = nameOfAFriend.Length;
        lengthOfText += currentLength;
        wholeText += nameOfAFriend;
    } while (lengthOfText < 20);
    Console.WriteLine("Thanks ,that was enough!" + wholeText);
}

// WHILE LOOP

// the while loop is a control flow structure that repeatedly executes a block of code as long as a specified 
//   condition is true

//SYNTAX OF WHILE LOOP  
while (condition)
{
    // code to be executed
}

// steps in while loop

//The loop checks the specified condition.
//If the condition is true, the block of code within the curly braces is executed.
//After the execution of the code in the block, the loop goes back to step 1 and repeats the process.
//If the condition becomes false, the loop exits, and the program continues with the next statement after the while loop.
*/
// example

{
    int count = 0;

    while (count < 5)
    {
        Console.WriteLine("Count: " + count);
        count++;
    }
}

//the condition count < 5 ensures that the loop will exit when count reaches 5.

{
    int counter = 0;
    string enteredText = "";
    while(enteredText.Equals(""))
    {
        Console.WriteLine("Please press enter to increase amount by one and anything else" + "+ enter if you want to finish counting");
        enteredText = Console.ReadLine();

        counter++;
        Console.WriteLine("Current people count is {0}",counter);

    }
    Console.WriteLine("{0} peoople are inside the bus. Press enter to close the program ",counter);

}





