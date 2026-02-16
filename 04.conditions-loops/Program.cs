/*
Creating a Console Application with the .NET CLI:
*************************************************

The following command creates a new console application:

    > dotnet new console --use-program-main

For this project we used the command: dotnet new console --use-program-main
To generate a console application with a complete C# program structure.

As we learnt, by default (starting with .NET 6), console templates use "top-level statements".
The "--use-program-main" option instructs the template engine 
to generate a traditional Program class with a Main method.

The Main method serves as the entry point of the application (As with Java).
When the program starts, execution begins inside Main.

Also be aware that the namespace is set to the project folder name (by default).
Since the project folder is named "04.conditions-loops", the namespace is "_04.conditions_loops".
The "_" is added because namespaces CANNOT start with a digit.

You can change the namespace to any valid name you prefer.

Link: https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new
Link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line
*/

namespace _04.conditions_loops;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conditions in C#");
        int a = 5;
        int b = 6;

        /*
        if statement is used to execute a block of code if a specified condition is true.
        like with other programming languages, if the code block contains only one statement, 
        the curly braces can be omitted, 
        but it's generally recommended to use them for better readability 
        and to avoid potential bugs when adding more statements later.
        */
        if (a + b > 10)
            Console.WriteLine("The answer is greater than 10.");
        else
            Console.WriteLine("The answer is not greater than 10");

        /*
        The Comparison Operators in C#:
        *******************************
        Like with other programming languages, C# comparison operators include:
        - Equal to => ==
        - Not equal to => !=
        - Greater than => >
        - Less than => <
        - Greater than or equal to => >=
        - Less than or equal to => <=   
        */

        /*
        The Logical Operators in C#:
        *****************************
        In C#, we also have the following 3 logical operators:
        - AND => &&
        - OR => || (called pipe symbol - pipes)
        - NOT => !
        
        > They are called "Logical Operators"
        > They are used to combine two or more conditions
        > They return a single Boolean value (true or false)
        */

        // Example Scenario (Toronto Public Library (TPL) - Think Practical Logic)
        /*
          3 Conditions to have a free library card:
          - Live in Toronto
          - Work in Toronto
          - Study in Toronto
         
          If (live in T OR work in T OR study in T)
          {
              Printing => Can have a library card
          }
          else
          {
              Printing => Cannot have a library card
          }
         */

        // Hard-coding the values (manually assigning true/false)
        bool liveInTo = false;
        bool workInTo = true;
        bool studyInTo = false;

        if (liveInTo || workInTo || studyInTo)
        {
            Console.WriteLine("You can have a library card!");
        }
        else
        {
            Console.WriteLine("You cannot have a library card!");
        }

        // The NOT operator (!)
        // *********************

        int age = 18;

        // Classical solution:
        // If age is greater than or equal to 18
        if (age >= 18)
        {
            Console.WriteLine("Yes, you can buy fireworks.");
        }

        /*
          Now let's repeat the same example using the NOT operator (!).
         
          The NOT operator reverses the result of a condition.
          true  becomes false
          false becomes true
         
          If (age is NOT less than 18)
          In C# => !(condition)
          Example: !(age < 18)
         */

        if (!(age < 18))
        {
            Console.WriteLine("Yes, you can buy fireworks.");
        }

        // AND (&&) and OR (||) Behavior
        // *****************************

        /*
          AND (&&)
          Both / All conditions must be TRUE to continue.
         
          Important: C# uses "short-circuit evaluation".
          This means:
          - If the first condition is FALSE,
            C# will NOT evaluate the rest of the conditions.
         
          Why?
          Because FALSE && anything is always FALSE.
         
          Examples:
          false && false = false
          false && true  = false
         
          Analyze this logic:
          if (5 >= 7 && 2 < 4)
         
          - First condition: 5 >= 7  => false
          - Since "AND" operator requires both conditions to be true,
            the second condition is NOT evaluated.
         */

        /*
          OR (||)
          At least ONE condition must be TRUE.
         
          Short-circuit rule:
          - If the first condition is TRUE,
            C# will NOT evaluate the rest.
         
          Why?
          Because TRUE || anything is always TRUE.
         
          Examples:
          true || true  = true
          true || false = true
         */


        // Practical Example of AND (&&)
        // *****************************

        /*
          Scenario:
          A student can register for a special course ONLY IF:
          - The student is 18 years old or older
          - The student has an average grade of 80 or higher
         
          Since BOTH conditions must be true,
          we use the AND operator (&&).
         */

        // Hard-coded example values
        int studentAge = 19;
        double studentAverage = 85.5;

        /*
          Condition:
          - studentAge >= 18  => TRUE
          *AND*
          - studentAverage >= 80 => TRUE
         */

        if (studentAge >= 18 && studentAverage >= 80)
        {
            Console.WriteLine("You are eligible to register for the course.");
        }
        else
        {
            Console.WriteLine("You do NOT meet the registration requirements.");
        }

        /*
          Important:
          The AND (&&) operator requires BOTH conditions to be TRUE.
         
          If the first condition is FALSE (for example, age < 18),
          C# will NOT even check the second condition.
         
          Example:
          16 >= 18 && 90 >= 80
          > First condition is FALSE
          > C# stops immediately
          > Final result is FALSE
         */

        // Using the "Ternary Operator" (?:)
        // *********************************

        /*
          The ternary operator is a shorter way to write a simple if-else statement.
         
          Syntax:
          condition ? value_if_true : value_if_false;
         
          It is called "ternary" because it uses three parts:
          1) A condition
          2) The result if the condition is TRUE
          3) The result if the condition is FALSE
         
          Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
         */

        // let's use the same fireworks example to demonstrate the ternary operator:

        // Classical way (as we did before):
        /*
        if (age >= 18)
        {
            Console.WriteLine("Yes, you can buy fireworks.");
        }
        else
        {
            Console.WriteLine("No, you cannot buy fireworks.");
        }
        */

        // Ternary operator version:
        string message = (age >= 18)
            ? "Yes, you can buy fireworks."
            : "No, you cannot buy fireworks.";
        // notice for readability, we formatted the "Ternary Operator" code in multiple lines.

        Console.WriteLine(message);

        /*
         - If (age >= 18) is TRUE => the first message is selected.
          - If (age >= 18) is FALSE => the second message is selected.
         
          The ternary operator is best used for simple conditions.
          If the logic becomes complex, it is better to use a regular if-else statement
          for better readability.
         */

        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops

        // Switch Statement Example in C#
        // *******************************
        /*
         We can use the switch statement to compare a variable against multiple values.
         it is a cleaner alternative to multiple if-else-if statements when you have many conditions to check against the same variable.

         Important:
            - The switch statement evaluates the variable once and compares it to each case.
                - Each case represents a possible value of the variable.
                - If a case matches, the code block for that case executes until a "break" statement is encountered.
                - Break statement is optional but commonly used to prevent fall-through (where execution continues to the next case).
                - If no cases match, the "default" case executes (if provided).
        */

        Console.WriteLine("Switch result:");

        // Hard-coded example
        string fruit = "apple";

        /*
         * In C#:
            - The switch statement can be used with various data types, including strings.
            - When using strings in a switch statement:
            > The switch compares the string value of "fruit" against each case.
            > the comparison is case-sensitive, meaning "Apple" and "apple" would be considered different values.
         */

        switch (fruit)
        {
            case "apple":
                Console.WriteLine("The fruit is apple");
                break;

            case "lemon":
                Console.WriteLine("The fruit is lemon");
                break;

            case "orange":
                Console.WriteLine("The fruit is orange");
                break;

            case "banana":
                Console.WriteLine("The fruit is banana");
                break;

            default:
                Console.WriteLine("Hmm!, so you like " + fruit);
                break;
        }

        /*
         * How it works:
         ***************
        - The switch statement evaluates the value of "fruit" once.
            - It compares "fruit" to each case in order.
            - If it finds a match (for example, "apple"):
                > it executes the code block for that case (printing "The fruit is apple") 
                > then encounters the "break" statement, which exits the switch immediately.
            - If no cases match (for example, if "fruit" was "grape"):
                > the switch would execute the code in the "default" case, 
                > printing "Hmm!, so you like grape".
            - The "break" statements are crucial to prevent "fall-through", 
              which is when execution continues into the next case if a break is not used. 
              In C#, if you omit the break statement, it will continue executing the next case's code until it hits a break 
              or the end of the switch block, which can lead to unintended behavior.
         */

        // Loops in C#:
        // ************
        Console.WriteLine("\nLoops in C#");
        // using "\n" to add a new line for better readability of the output.
        /*
        C# has several types of loops, including:
        - while loop
        - do-while loop
        - for loop
        - foreach loop
        */
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"The counter is {counter}");
            counter++;
        }
        /*
        NOTE:
        - The while loop continues to execute as long as the condition (counter < 10) is true.
        - Inside the loop, we print the current value of counter and then increment it by 1.
        - Once counter reaches 10, the condition becomes false, and the loop terminates.
        - make sure to avoid infinite loops by ensuring that the loop's condition will eventually become false. 
          In this example, since we are incrementing counter, it will eventually reach 10 and stop the loop.
        With the case of infinite loops, we can use "Ctrl + C" in the terminal to stop the execution of the program.
        */

        /*
            The do ... while loop is similar to the while loop, 
            but it guarantees that the code block will execute at least once, 
            even if the condition is false from the beginning. 
        */
        int doCounter = 0;
        do
        {
            Console.WriteLine($"The doCounter is {doCounter}"); doCounter++;
        } while (doCounter < 10);
        /*
        - The do-while loop executes the code block first and then checks the condition.
        - In this example, even if we had initialized doCounter to a value greater than or equal to 10, 
        the code block would execute at least once before the condition is evaluated.
        */

        /*
           The "for" loop is a more compact way to write a loop that includes 3 parts:
           > initialization
           > condition
           > iteration 
           all in one line. 
        */
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"The for loop counter is {i}");
        }
        /*
        - The for loop consists of three parts:
        1) Initialization: int i = 0; (this runs once at the beginning

        2) Condition: i < 10; (this is checked before each iteration)
        3) Iteration: i++ (this runs after each iteration)
        - In this example, the loop will print the value of i from 0 to 9.

        NOTE:
        The for loop counter has a "limited scope", meaning it only exists within the loop. 
        If you try to access "i" outside of the loop, you will get an error because "i" is not defined outside of the loop.
          - it's called "local variable" because it is only accessible within the block of code where it is defined (in this case, the for loop).
          
          so local variables have "local scope", 
          which means they can only be accessed within the block of code where they are defined.   
        */

        // Created nested loops:
        for (int row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'h'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }


        // Other example of nested loops:
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Outer loop iteration: {i}, starting inner loop...");
            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine($"\tInner loop iteration: {j}");
                // The "\t" is used to add a tab space for better readability of the inner loop output.
            }
        }

        /*
            Don't forget about the "Code Snippets" feature in Visual Studio Code (Ctrl + Shift + P => Insert Snippet => C#)
            The coe snippets are pre-defined templates that can help you write code faster and with fewer errors.
            WE can just type for example "for" and then press "Tab" key to generate a for loop template.
            Notice that VS code shows two "for" words:
            > one is just the keyword "for"
            > the other one is the "for" loop code snippet template.
        */


        /*
        for each loop is used to iterate over a collection (like an array, list, etc.) 
        without needing to manage the loop counter manually.
        It is a cleaner and more readable way to loop through items in a collection.
        */
    } // End of Main method
} // End of Program class

/*
NOTES TO REMEMBER:
******************
- In C# like other programming languages, we use curly braces {} to define a block of code.
A block of code is a group of statements that are executed together.
For example, in an if statement, the block of code is the part that gets executed if the condition is true. 
- In a loop, the block of code is the part that gets executed for each iteration of the loop. 
In C#, we can have nested blocks of code, which means we can have blocks of code inside other blocks of code.   
- Variables defined inside a block of code are called "local variables" and they can only be accessed within that block of code.
- Local variables have "local scope", which means they can only be accessed within the block of code where they are defined.
- Variables defined outside of any block of code are called "global variables" and they can be accessed from anywhere in the program.
- Global variables have "global scope", which means they can be accessed from anywhere in the program.
*/
