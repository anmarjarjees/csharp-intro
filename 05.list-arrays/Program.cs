/*
To Review:
**********
The dotnet CLI command for creating a new console app project with the full C# code structure, 
including the Program class and Main method, is:
> dotnet new console --use-program-main
The command generates a new console application with the necessary files and structure to run a C# program. 
The --use-program-main option indicates that the generated code will include a Program class with a Main method, 
which serves as the entry point of the application.

For more details refer to the previous project C# File. 
*/
using System.Text;

namespace _05.list_arrays;

class Program
{
    static void Main(string[] args)
    {
        /*
        Lists and arrays are fundamental data structures in C#.
        An array is a fixed-size collection of elements of the same type, 
        while a list is a dynamic collection that can grow and shrink in size.

        List<T> => pronounced "List of T", where "T" is a placeholder for the type of elements the list will hold.
        */
        Console.WriteLine("Working with lists and arrays in C#");

        /*
        About Implicit Global Usings (.NET 6+):
        ***************************************       
        The List<T> class belongs to the System.Collections.Generic namespace.

        Normally, we must include (at the top of the file) the using directive to use the List<T> class:

            > using System.Collections.Generic;

        As we learnt before, The "using" directive allows us to reference types in a namespace
        without writing their fully qualified name.

        Example without using:

        System.Collections.Generic.List<string> names = new System.Collections.Generic.List<string>();

        Starting with .NET 6, new projects enable a feature called "Implicit Global Usings" by default.

        This is configured in the .csproj file:

            <ImplicitUsings>enable</ImplicitUsings>
        
        When enabled, the compiler automatically includes common namespaces
        at compile time, including:

            System
            System.Collections.Generic
            System.Linq
            System.Text
            System.Threading.Tasks

        Notice that "ImplicitUsings" is set to "enable" by default in new console app projects created with the dotnet CLI,
        which is why we can use List<T> and Console.WriteLine without manually including the using
        directives for "System.Collections.Generic" and "System" at the top of this file.

        Important:
        **********
        The dotnet CLI does NOT physically insert these using directives into Program.cs.
        Instead, they are injected by the compiler based on project settings.

        If implicit usings are disabled, we must manually add:

            > using System.Collections.Generic;
        */

        /*
        C# provides the generic List<T> class in the "System.Collections.Generic" namespace.
        The <T> represents a type parameter, which means List<T> can store elements of any specified type.
        Where "T" is a placeholder for the type of elements the list will hold.

        Normally, to use List<T>, we must explicitly include the namespace at the top of the file:
            using System.Collections.Generic;

        This the same as we do in "Java" when we import packages using the import statement with keyword "import",
        in C# we use the using directive with the keyword "using" to include namespaces that contain classes and other types we want to use in our code.

        The using directive allows us to reference types defined in a namespace
        without writing the fully qualified name every time.
        
        For example, without the using directive, to declare a list of strings,
        we would have to write:
            System.Collections.Generic.List<string> names = new System.Collections.Generic.List<string>();

        However, starting with .NET 6, new console applications created with the dotnet CLI
        enable a feature called "Implicit Global Usings" by default.

        This feature is configured in the project file (.csproj) with:
            <ImplicitUsings>enable</ImplicitUsings>
        
        If <ImplicitUsings> is set to disable, then we must manually add:
            using System.Collections.Generic;
        Otherwise, the code will not compile.

        When implicit usings are enabled, the compiler automatically includes
        a set of commonly used namespaces at compile time,
        including:

        System
        System.Collections.Generic
        System.Linq
        System.Text
        System.Threading.Tasks

        Because of this feature, we can use List<T> directly in this file
        without manually writing:
        using System.Collections.Generic;

        Which is also the same reason why we can use Console.WriteLine without including "using System;" at the top of the file.
        Before C# 10 and .NET 6, we would have had to include "using System;" to use Console.WriteLine, 
        but with implicit global usings, it's automatically included for us.

        Link: https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#implicitusings
        */

        /*
        Object Instantiation & Target-Typed:
        ************************************
        
        Creating a List<T> Instance (object instantiation). Objects and Classes will be covered in more details in this repo :-)
        
        To create an object in C#, we use the "new" operator.
        This allocates memory and calls the constructor of the class.

        General Template:
            ClassName variableName = new ClassName();

        Classic syntax:

            List<string> names = new List<string>();

        Starting with C# 9, we can use a feature called "target-typed new expression".

        Because the compiler already knows the type from the left side,
        we can omit the type on the right side :-) 
        Yes, with Java, we can also omit the type on the right side when using the diamond operator <> for generics, 
        
        But in C#, we can omit the entire "new List<string>()" and just use "new()":

            > List<string> names = new();

        This simplifies code but still requires the "new" keyword.

        Important:
        **********
        We CANNOT remove the "new" keyword.
        The following is INVALID:

            List<string> names = List<string>();  // Not allowed

        Error Message: "Error CS1955: Non-invocable member 'List<T>' cannot be used like a method."

        Because List<T> is a type, not a method.

        Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-new
        */

        // Examples of creating lists:

        // In this example, we create a list of strings to store names.
        /*
         We can initialize the list using the "List<T>" constructor, 
         and we can specify the type of elements it will hold by replacing "T" with the desired type, in this case, "string".
         The "new" keyword is used to create a new instance of the List<string> class, 
         and we can optionally provide an initial capacity for the list by passing an integer argument to the constructor,
         which can help optimize performance if we know the expected number of elements in advance.       
        */

        // Way#1: Declaring a list of strings using the List<T> constructor using the classical syntax:
        List<string> names = new List<string>();

        // Way#2: Declaring a list of strings using the List<T> constructor with the "new" keyword and target-typed new expression:
        List<string> cities = new();


        /*
        Collection Expressions (C# 12):
        *******************************
        Starting with C# 12 and .NET 8, we can use "Collection Expressions" to create and initialize collections in a more concise way.
        This allows us to use the [] syntax to create lists, similar to how we create arrays, but with the flexibility of lists.
        
        For examples:
        - we can create a empty list of integers like this:
            
            > List<int> numbers = [];

        - we can create and initialize a list of integers like this:

            > List<int> numbers = [1, 2, 3, 4, 5];

        These are modern syntax and requires C# 12 or later.

        Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/collection-expressions
        */


        /* 
        The "new" keyword in C#:
        ************************
        In C# 9 and later:
        - we can skip the word "new", as it's not required, 
            That's why VS Code will show a warning for the keyword "new": 
                > 'new' expression can be simplified
                > Collection initialization can be simplified

        - we can also simplify the instantiation of objects using the "target-typed new expression" feature.    
            This is because the compiler can infer the type of the list from the variable declaration,

        so we can simplify the code by using the target-typed new expression, 
        which allows us to omit the type on the right-hand side of the assignment when it can be inferred from the context.
        
        The code can be simplified to be just as this:
            List<string> names = [];
        */

        // Way#3: Declaring a list using the modern simple syntax as with arrays using [] brackets (C# 12 and .NET 8):
        List<string> programLanguages = [];

        // We can add elements to the list using the Add method, and we can access the elements using an index or by iterating through the list.
        /* 
        Using the properties and methods of the List<T> class, 
        we can perform various operations on the list, such as adding, removing, and searching for elements,
        as well as accessing the count of elements in the list and iterating through the list using

        > objectName.PropertyName for properties.
        > objectName.MethodName() for methods, 
        */

        // Way#4: Creating and initializing a list of strings using collection initializer syntax:
        // This allows us to create a list and add elements to it in a single statement using the {} initializer syntax.

        // A) Using the classical syntax with the "new" keyword and collection initializer:
        List<string> colors = new List<string> { "Red", "Green", "Blue" };
        /*
        C# Warning for Example A:
            > Collection initialization can be simplified
            > 'new' expression can be simplified
        */

        // B) Using the target-typed new expression and collection initializer:
        List<string> fruits = new() { "Apple", "Banana", "Orange" };
        /*
        C# Warning for Example B:
            > Collection initialization can be simplified
        */

        // C) Using the modern simple syntax with collection initializer (C# 12 and .NET 8):
        List<string> animals = ["Dog", "Cat", "Elephant"]; // No warnings for this example, as it's the most modern syntax :-)

        // Adding elements to the list "names" using the Add method:
        names.Add("Alex");
        names.Add("Chow");
        names.Add("Sam");
        names.Add("Simpson");

        // adding elements to the list "cities":
        cities.Add("Toronto");
        cities.Add("Mississauga");
        cities.Add("Brampton");
        cities.Add("Vaughan");

        // adding elements to the list "programLanguages":
        programLanguages.Add("C#");
        // C# is a programming language developed by Microsoft that runs on the .NET framework.

        programLanguages.Add("Java");
        // Java is a widely used programming language that runs on the Java Virtual Machine (JVM) and is known for its portability and performance.

        programLanguages.Add("Python");
        // Python is a high-level programming language known for its simplicity and readability, often used for web development, data analysis, and machine learning.

        programLanguages.Add("JavaScript");
        // JavaScript is a versatile programming language primarily used for web development to create interactive and dynamic web pages,
        // running in the browser and on the server with Node.js.    

        programLanguages.Add("Typescript");
        // TypeScript is a superset of JavaScript that adds static typing and other features to enhance the development experience,
        // Often used for large-scale web applications to improve code maintainability and catch errors during development

        programLanguages.Add("PHP");
        // PHP is a server-side scripting language commonly used for web development to create dynamic web pages and applications
        // Often embedded within HTML.

        programLanguages.Add("C++");
        // C++ is a powerful programming language that provides low-level memory manipulation capabilities and is commonly
        // used for system programming, game development, and performance-critical applications.

        // Notice what happens when we try to print the list directly using Console.WriteLine:
        Console.WriteLine($"\nRow Display: {names}"); // Output: Row Display: System.Collections.Generic.List`1[System.String]

        // Using the Count property to get the number of elements in the list and accessing the first element using an index:
        Console.WriteLine($"\nNumber of members: {names.Count}"); // Output: Names in the list: 4

        /*
        NOTE:
        *****
        lists and arrays in C# are zero-based, which means:
            > that the first element is at index 0 
            > the second element is at index 1
            > the third element is at index 2 and so on.
            > the last element is at index Count - 1, where Count is the total number of elements in the list.

        When we try to print the list directly using Console.WriteLine,
        it does not display the contents of the list but instead shows the type of the list,
        which is "System.Collections.Generic.List`1[System.String]".
        This is because Console.WriteLine calls the ToString() method on the list object, 
        and the default implementation of ToString() for a List<T> returns the type name rather than the contents of the list.
        */

        // To print an element of the list, we can use an index to access it (same syntax as with arrays).
        // Example: To access the first element of the list, we can use the index 0, since list indices are zero-based:
        // using names[0] => pronounced "names at index 0":
        Console.WriteLine($"First member: {names[0]}"); // Output: First member: Alex

        // Second element => has index 1: => names at index 1
        Console.WriteLine($"Second member: {names[1]}"); // Output: Second member: Chow

        // Third element => has index 2: => names at index 2
        Console.WriteLine($"Third member: {names[2]}"); // Output: Third member: Sam

        // Fourth element => has index 3: => names at index 3
        Console.WriteLine($"Fourth member: {names[3]}"); // Output: Fourth member: Simpson

        // Since the index of the last element is Count - 1, we can access the last element using:
        Console.WriteLine($"Last member: {names[names.Count - 1]}"); // Output: Last member: Simpson

        /*
        However, VS Code will show a warning for the above line of code!
        Yes, in C# version 8.0 and later, we can use the "index from end" syntax to access elements from the end of the list,
        which simplifies the code and improves readability.
            > Accessing the last element of the list can be simplified
            > Use 'names[^1]' instead of 'names[names.Count - 1]'
            - Using the caret (^) symbol followed by an index allows us to access elements from the end of the list, 
              where:
              - ^1 represents the last element
              - ^2 represents the second-to-last element
              - ^3 represents the third-to-last element, and so on.
        */

        // Example: Accessing the last element (city) in the cities list using the "index from end" syntax:
        Console.WriteLine($"\nLast city: {cities[^1]}"); // Output: Last city: Vaughan

        /*
        We can iterate through the list using a loop to print all the elements.
        For example, we can use a foreach loop to iterate through the list and print each name
        */
        Console.WriteLine("\nNames in the list:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // We can also use the keyword "var" to let the compiler infer the type of the variable when iterating through the list:
        Console.WriteLine("\nCities in the list:");
        foreach (var city in cities)
        {
            // Since "city" is a string, we can use one of its methods :-)
            // We can convert the city name to uppercase using the ToUpper() method:
            Console.WriteLine(city.ToUpper());
        }

        // which the same idea as declaring variable with "var" keyword when we create a list:
        var numbers = new List<int>(); // The compiler infers that "numbers" is of
        var maxGrade = 100; // The compiler infers that "maxGrade" is of type int
        var firstName = "Alex"; // The compiler infers that "firstName" is of type string
        var isValid = true; // The compiler infers that "isValid" is of type bool
        var pi = 3.14; // The compiler infers that "pi" is of type double

        Console.WriteLine($"\nMax grade: {maxGrade}"); // Output: Max grade: 100
        Console.WriteLine($"\nFirst name: {firstName}"); // Output: First name: Alex
        Console.WriteLine($"\nIs valid: {isValid}"); // Output: Is valid: True
        Console.WriteLine($"\nValue of pi: {pi}"); // Output: Value of pi: 3.14

        // we can also use the loop counterpart "for" loop to iterate through the list using an index:
        Console.WriteLine("\nProgramming languages in the list:");
        for (int i = 0; i < programLanguages.Count; i++)
        {
            Console.WriteLine(programLanguages[i]);
        }

        // Working with Ranges "Range Operator" (C# 8.0 and later): 
        // ********************************************************
        /*
        We can use [start-index .. end-index] syntax to access a range of elements in the list, 
        > start-index (included)
        > end-index (excluded)
        
        Which is called "range operator" in C# 8.0 and late.

        This feature works with arrays and with types that support:
            > the System.Range indexer (such as List<T> in modern .NET versions).
        */
        // Example: Accessing a range of elements from the "programLanguages" list:
        Console.WriteLine("\nProgramming languages from index 1 to 3:");
        foreach (var language in programLanguages[1..4]) // This will include elements at indices 1, 2, and 3 (but not index 4)
        {
            Console.WriteLine(language);
        }
        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes

        // Same idea as with arrays, we can also use the "for" loop to iterate through the list using an index,
        // but we need to use the Count property instead of Length, since lists do not have a Length property like arrays do.

        // Array Examples:
        // A) Declaring an array of strings using the traditional syntax:
        string[] namesArray = new string[4];
        // "new" keyword warning:Collection initialization can be simplified
        namesArray[0] = "Alex";
        namesArray[2] = "Sam";
        namesArray[1] = "Chow";
        namesArray[3] = "Simpson";

        // B) Declaring and initializing an array of strings using the traditional syntax:
        string[] instrumentsArray = new string[] { "Guitar", "Piano", "Drums", "Violin" };

        // C) Declaring and initializing an array of strings using the modern simple syntax with [] brackets (C# 12 and .NET 8):
        string[] citiesArray = ["Toronto", "Mississauga", "Brampton", "Vaughan"];

        // This will cause an error because the array has a fixed size of 4 and cannot hold more than 4 elements.
        // namesArray[4] = "Sarah"; // This will throw an "IndexOutOfRangeException" at runtime
        // Error Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array

        Console.WriteLine("\nNames in the Array \"namesArray\":");
        for (int i = 0; i < namesArray.Length; i++)
        {
            Console.WriteLine(namesArray[i]);
        }

        /*
        When we initialize an array using an initializer list,
        the compiler determines the array size based on the number
        of elements provided in the initializer.

        In this case, the array size is 4,
        so valid indices are 0, 1, 2, and 3.

        Attempting to access index 4 will throw IndexOutOfRangeException at runtime.
        */

        // citiesArray[4] = "Markham"; // This will throw an "IndexOutOfRangeException" at runtime
        // Error: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
        Console.WriteLine("\nCities in the Array \"citiesArray\":");
        for (int i = 0; i < citiesArray.Length; i++)
        {
            // Also, we can use the ToUpper() method to convert the city name to uppercase when printing it:
            Console.WriteLine(citiesArray[i].ToUpper());
        }

        // Sorting a list:
        // **************
        /*
        The List<T> class provides a built-in method called Sort().

        > Method Name: Sort()
        > Behavior: Sorts the elements of the list in ascending order by default.

        Important:
        ----------
        - For strings => sorted alphabetically (A => Z)
        - For numbers => sorted numerically (smallest => largest)
        - The sorting modifies the original list (in-place).
        */

        // Using the "Sort()" method => Ascending by default  
        names.Sort();  // Ascending (alphabetical)

        Console.WriteLine("\nSorted Name List (Ascending):");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Link: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-10.0

        /*
            Summary:

            Arrays:
            - Fixed size once created
            - Store elements of the same type (same as List<T>)
            - Slightly more memory-efficient
            - Length property

            List<T>:
            - Dynamic size (internally resizes its backing array)
            - Store elements of the same type (same as arrays)
            - More flexible for unknown collection sizes
            - Count property
            */

        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/list-collection
        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections
        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

    } // end of Main method
} // end of Program class