/* 
NOTE:
By default, C# compiler uses a C# feature called "Top-Level Statement" since .NET 6
So no need to add all the boilerplate for a full C# Class file as we do in Java,

TIP:
In Java, we need to create a class and a main method to run our application,
In C#, we can write our code directly in the file without the need for a class or a main method, 
as the compiler will automatically generate a class and a main method for us behind the scenes
by adding the class name and the main() method as the entry point to launch our application
Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview

However, if we want to write our code in a more traditional way with a "class" and a "main method", 
we can do that as well, so we can write our code like this:
using System; 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Learning C# as Programming Language");
    }
}
*/

internal class Program
{
    /* 
    The Main method:
    ****************
    In C#, the "Main" method is the entry point of a console application,
    where the program starts executing,
    > Must be: declared as "static" 
    > Can have a return type of "void" or "int" (if we want to return an exit code).
    The "args" parameter is an array of strings that can be used to pass command-line arguments to the application when it is executed, 
    similar to the "args" parameter in Java's main method.

    Notice that in C#, we use "PascalCase" for method names by convention if the method is "public",  
    while we can use "camelCase" for private methods, but it's not a strict rule, it's just a convention to follow for better readability and maintainability of the code,
    unlike what we do in Java, JS where we use "camelCase" for all method names (public or private).

    More details about the Main method and its variations will be covered in this repo later :-)

    Link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line#overview
    link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions#method-names
    */
    private static void Main(string[] args)
  {
    /* 
    Printing to the Console:
    ************************
    Using Console.WriteLine() to print a message to the console,
    as with Java, we can use it to print any message to the console
    in Java we use System.out.println() to print a message to the console
    */
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Learning C# as Programming Language");
    } // end of Main method
} // end of Program class

/* 
Good to know :-)
****************
To format the code in Visual Studio, we can use the shortcut "ALT + SHIFt + F" to format the code,
or we can right-click on the code and select "Format Document" to format the code,
This will help us to keep our code clean and organized, and it will also help us to follow the coding conventions and best practices for C# programming language.
 */