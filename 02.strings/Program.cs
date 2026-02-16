// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// We will also convert it to the normal full content of a C# program:
// Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview#hello-world

/*
The "using" directive in C#:    
****************************
In C#, we use the "using" directive to include namespaces in our code,
similar to the "import" statement in Java.
For example, we use "using System;" to include the System namespace,
which contains the Console class that we use to print messages to the console.
*/
using System;

/*
The "namespace" in C#:
*********************
Notice that in C#, we usually have a "namespace" to contain our classes, As with Java packages.
For simplicity, we will skip it for now,
so we can write our code directly in the file without the need for a namespace,
as the compiler will automatically generate a namespace for us behind the scenes.
However, if we want to write our code in a more traditional way with a "namespace",
we can do that as well, so we can add the namespace like this:

namespace StringsApp
{
    // Our classes and methods will go here
}

Please consider the following:
******************************
1) Notice the "namespace" name "StringsApp" above,
we usually use "PascalCase" for namespace names by convention in C# and without spaces,
unlike what we do in Java where we use all lowercase letters for package names.

2) The namespace is a way to organize our code and avoid naming conflicts between different classes and methods in our application,
so we can have multiple classes with the same name in different namespaces without any issues.

3) The previous versions of C#, "namespaces" used to have open and close curly braces to contain the classes 
and methods inside it, 
but in the latest versions of C# since C# 10, we can use what's called "file-scoped namespaces" 
which allow us to write our code without the need for curly braces for the namespace, as shown in our example below.

We used "file-scoped namespaces" which allow us to write our code without the need for curly braces for the namespace, as shown in the example above.
*/
namespace StringsApp;

class Program
{
    static void Main()
    {

        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=3
        // Adding string (sequence of characters) variables:
        // As with Java, using "" for string variables:
        string firstSubject = "C-Sharp";
        string secondSubject = "ASP.NET";

        /* 
        Unlike Java, where we have the "String" class with an uppercase "S",
        In C#, we use "string" with a lowercase "s" as an alias for the "String" class in the System namespace.
        Both "string" and "String" can be used interchangeably in C#, 
        but it's more common to use "string" for variable declarations 
        and "String" for method calls and other operations related to the string class.    
        */
        String thirdSubject = "Blazor"; // Valid also in C#, but not recommended for variable declaration
        /*
        Notice that VsCode is giving us a hint that it's better to use "string" instead of "String" for variable declaration,
        that's because "string" is an alias for "String" in C#, and it's more common to use "string" for variable declarations,
        and that's why it's dimmed in VsCode as a hint.
        */
        Console.WriteLine(thirdSubject); // Blazor

        // Using the simple + for concatenating as with many other programming languages:
        Console.WriteLine("Learning " + firstSubject + " first, then " + secondSubject + " later");
        /*
        Using the "+" operator to concatenate strings is not recommended => may lead to performance issues.
        Especially when concatenating multiple strings in a loop. 
        Instead, it's better to use "String Interpolation" as shown below,
        or the "StringBuilder" class for more efficient string concatenation (For later). 
        However, for simple cases, using "+" is still acceptable as in the example above.
        */

        // Easier version :-) String Interpolation:
        // Using the "$" for string interpolation with "{" and "}" to contain the variables 
        // NOTE: String Interpolation was introduced in C# 6 and later versions
        Console.WriteLine($"Learning {firstSubject} first, then {secondSubject} later");
        /* 
        We used "$" for string interpolation like formatting a string with Java using printf() method, 
        but in C# we use "$" for string interpolation and "{" and "}" to contain the variables we want to print in the string.
        */

        // Main String Methods:
        // ********************
        /* 
        Trimming a string:
        ******************
        Three methods for trimming a string (removing white spaces before and after the string):
        - TrimStart() =>  public String TrimStart();
        - TrimEnd() => public String TrimEnd();
        - Trim() => public String Trim();

        Notice that all these are public methods,
        In C#, we use PascalCase for public methods by convention
        unlike what we do in Java, JS
         */
        string greeting = "      Learning C# Language!       ";
        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.TrimStart(); // trim the white spaces at the start of the string
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.TrimEnd(); // trim the white spaces at the end of the string
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.Trim(); // trim the white spaces at the start and end of the string
        Console.WriteLine($"[{trimmedGreeting}]");

        /* 
        Contains, Search and Replace:
        *****************************
        Using Contains() method:
            > to check if a string contains a specific substring
            > Takes one parameter: the substring to search for
            > Returns a boolean value (true if found/false if not found)
         */
        string quote = "When there is a will, there is a way";
        Console.WriteLine(quote.Contains("will")); // True
        Console.WriteLine(quote.Contains("way")); // True
        Console.WriteLine(quote.Contains("why")); // False

        /* 
        Replace():
            > Replaces all occurrences of a specified substring with another substring in the original string.
            > Takes two parameters: the substring to be replaced and the new substring to replace it with.
            > Returns a new string
        
        Notice that the code below will return a new string (new space in the memory)
        it will not change/override the original one:

        As with Java, Some methods in C# might/might not change the original variables

        Since "String" in C# are "Immutable" variables,
        which means we cannot change it unless we override them
        as we did below by overriding the variable "welcomeMsg" itself

        It's called "Explicit" change
         */
        string welcomeMsg = "Hello Everyone!";
        Console.WriteLine(welcomeMsg); // Hello Everyone!   

        Console.WriteLine(welcomeMsg.Replace("Everyone", "Everybody!")); // Hello Everybody!

        Console.WriteLine(welcomeMsg); // Hello Everyone!
        /*
        Notice that the original string variable "welcomeMsg" is not changed by applying the Replace() method,
        because strings in C# are "immutable", so the Replace() method returns a new string with the specified replacements, 
        but it does not modify the original string variable "welcomeMsg".
        */

        welcomeMsg = welcomeMsg.Replace("Hello", "Greetings");
        /*
        Notice that we have overridden the variable "welcomeMsg" itself by assigning it to the new string returned by the Replace() method,
        so we have changed the original string variable "welcomeMsg" to the new string "Greetings Everyone
        */
        Console.WriteLine(welcomeMsg); // Greetings Everyone!

        /* 
        Two methods for changing the case of a string:
        **********************************************
        > ToUpper(): 
            - Converts all characters in the string to uppercase
        > ToLower():
            - Converts all characters in the string to lowercase
        */
        Console.WriteLine(welcomeMsg.ToUpper()); // GREETINGS EVERYONE!
        Console.WriteLine(welcomeMsg.ToLower()); // greetings everyone

        // for testing:
        Console.WriteLine(welcomeMsg); // Greetings Everyone!
        /* 
        String are immutable, so the original string variable 
        will not be changed by applying these methods
         */

        /* 
         Two methods that also search for sub-strings in a string.
         - StartsWith()
         - EndsWith()
         */

        Console.WriteLine(quote.StartsWith("When")); // True => because the string "quote" starts with "When"
        Console.WriteLine(quote.StartsWith("way")); // False => because the string "quote" does not start with "way"
        Console.WriteLine(quote.EndsWith("way")); // True => because the string "quote" ends with "way"
        Console.WriteLine(quote.EndsWith("When")); // False => because the string "quote" does not end with "When"

        /* 
        String has properties also like "Length"
        */
        Console.WriteLine(quote.Length); // 36 => 36 characters

        /* 
        You can use the C# hints to learn more about other String methods
        */
        // This line prints "Hello, World" 
        Console.WriteLine("Hello, World");

        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=5

        /* 
        Notice that:
        - All the String methods we used above are public methods,
        so we used "PascalCase" for them by convention in C#,
        unlike what we do in Java, JS where we use camelCase for all method (functions) names (public or private).  

        - VS Code is giving us hints about the methods we are using, and it also shows us the parameters that we need to pass to the method, and the return type of the method, which is very helpful for learning and understanding how to use the methods in C#.

        - VS Code also shows the stars for the methods we are using, which indicates the popularity of the method among C# developers, and it also shows us the number of times the method has been used in the C# community, which is also helpful for learning and understanding how to use the methods in C#.
         */
    } // end of Main method
} // end of Program class
