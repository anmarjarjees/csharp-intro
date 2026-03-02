/*
To review:
**********
Running the dotnet CLI command:
    
    > dotnet new console --use-program-main

This command:
- Creates a new Console Application project
- Generates the Program class
- Adds the Main method (application entry point)

By default:
- The namespace is based on the project name.
- C# identifiers (including namespaces) cannot start with a digit.
- If the project name starts with a number, the SDK automatically
  modifies it (for example, by adding an underscore "_").
*/
namespace _06.linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LINQ: Language Integrated Query");
        /*
        LINQ (Language Integrated Query):
        *********************************

        LINQ is a feature in C# that allows us to query data
        (such as arrays, lists, or other collections)
        using a readable and consistent syntax.

        Instead of manually writing loops to filter or sort data,
        LINQ provides a declarative way so we can describe:
            > WHAT we want
            > Not HOW to iterate step by step

        LINQ works with any type that implements IEnumerable<T>

        Link: https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/introduction-to-linq-queries
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/linq/
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq
        */

        /*
        Coding Essential Review About "Variables" In Any Language:
        - Declaring => defining the variable name and type
        - Initializing => assigning its first value
        - Both are happening in the same statement
        */

        // Data Sources:
        // *************
        // Declaring and initializing an array and a list using collection expressions (C# 12 syntax):

        // Declaring and initializing the data source as array:
        int[] scoresArray = [97, 92, 81, 60, 75];
        /*
        int[] => Declaring the type (array of integers)
        [ ... ] => Collection expression (C# 12 feature) used to initialize the array with values
        */

        // Declaring and initializing the data source as List:
        List<int> scoresList = [97, 92, 81, 60, 75];
        /*
        List<int> => Generic List collection of integers
        [ ... ] => Collection expression (C# 12 feature)
        */

        /*
        NOTE:
        *****
        Both arrays and lists implement IEnumerable<T>.
        That is why we can query them using LINQ.
        */

        /*
        Task: Find all scores that are 90 or greater?
        */

        // Traditional Approach (Imperative Style):
        // ****************************************
        Console.WriteLine("\nScores Array: 90+ (using for loop)");

        // For arrays, we use the "Length" property
        for (int i = 0; i < scoresArray.Length; i++)
        {
            if (scoresArray[i] >= 90)
                Console.WriteLine($"Score: {scoresArray[i]}");
        }

        Console.WriteLine("\nScores List: 90+ (using for loop)");

        // For lists, we use the "Count" property
        for (int i = 0; i < scoresList.Count; i++)
        {
            if (scoresList[i] >= 90)
                Console.WriteLine($"Score: {scoresList[i]}");
        }

        // return;
        /*
        NOTE: To Review:
        > The "return" keyword immediately terminates the execution
            of the current method (Main in this case).
        > Any code written after "return" will NOT execute.
        */

        // Using LINQ Query Expression Syntax:
        // ***********************************
        /*
        Defining the query expression

        Important LINQ Concepts:
        ************************

        Understanding IEnumerable<T>:

        - IEnumerable<T>
            => An interface that represents a "sequence of elements" that can be iterated over 
               [Can be iterated (looped) over]
            => Is located in "System.Collections.Generic namespace"

        - LINQ query expressions return an "IEnumerable<T>" interface
        
        - The query variable does NOT store the final results immediately
          LINQ uses deferred execution.
          The query executes when we iterate over it (for example, using foreach)

        - Any collection that implements IEnumerable<T> can be used with LINQ
 
        Examples of collections that implement IEnumerable<T>:
        ******************************************************
        - Arrays
        - List<T>
        - Many other collection types

        Important Concept: "Deferred Execution"
        ***************************************

        When we write a LINQ query like:

            IEnumerable<int> scoreArrayQuery = ...

        The query is NOT executed immediately.

        Instead:
        - The variable stores the query definition.
        - The actual filtering happens only when we iterate over it
          (for example, using foreach).

        This behavior is called "Deferred Execution"
        */


        // LINQ query with array:

        // "scoreArrayQuery" => query variable (stores the query definition)
        IEnumerable<int> scoreArrayQuery =
            from score in scoresArray // required: defines the range variable and data source
            where score >= 90 // optional: filters the data
            select score; // required: every query must end with select or group


        // LINQ query with list (same as above):

        IEnumerable<int> scoreListQuery =
            from score in scoresList
            where score >= 90
            select score;

        /*
        Important NOTE:
        ***************
        - Both linq queries with arrays and lists are the same
        - The query has NOT executed yet
        - This is called Deferred Execution
        - The query runs only when we iterate over it
        */

        Console.WriteLine("\nScores List: 90+ (after using Linq):");

        // Execute the query using any type of loops:
        foreach (var score in scoreArrayQuery)
        {
            Console.Write(score + " ");
        }
        // Output: 97 92
        Console.WriteLine();

        /*  
        Compare Both Approaches:
        ************************

        Using "for" loop:
        - We manually control:
            > the index
            > the condition
            > the increment
        - This style is called "Imperative Programming"
        because we describe HOW the operation should be done.

        Using "LINQ":
        - We describe WHAT we want:
            > scores where score >= 90
        - We do NOT manually control the loop.
        - This style is called "Declarative Programming"
        */

        // More LINQ Query Expression Examples:
        // ************************************
        // Digging more into LINQ expressions basics:
        List<int> averages = [90, 87, 91, 73, 91, 79];

        /*
        Using "orderby":

        - orderby sorts the results (ascending by default)
        - ascending is default
        - descending must be explicitly specified
        */
        IEnumerable<int> averageQuery =
          from average in averages
          where average >= 90
          orderby average descending // or using ascending (by default so no need to mention)
          select average;

        /*
          Query Expression Keywords used above:
          - from
          - where
          - orderby
          - select

          Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords
        */

        foreach (var average in averageQuery)
        {
            Console.Write(average + " ");
        }

        /* 
         "int" to "string":
         ******************
         The following example shows a projection from an int to a string. Note the new type of highScoresQuery.
         An example of returning a string from a list of integers.
         Link: https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/query-expression-basics      
        */

        // using the list variable "averages" again in the two examples below:
        // Example1 (int to string): two steps as usual
        IEnumerable<string> averageQuery2 =
            from average in averages
            where average >= 90
            orderby average descending
            // select average; // Error (runtime): Cannot implicitly convert type int... to string...
            select $"The average value is: {average}";

        // then looping to print the result:
        Console.WriteLine("\n\nAverage Query#2: \n****************");
        foreach (string avg in averageQuery2) // we can also use var avg instead of specifying the type string avg
        {
            Console.WriteLine($"Average foreach loop => {avg}");
        }


        /*
        Deferred Execution vs Immediate Execution:
        ******************************************
        To recall:
            - Our LINQ queries returned IEnumerable<int>
            - so the "averageQuery" is NOT a "List" or "Array". It is an IEnumerable<int>.

        Remember:
        *********
        - IEnumerable<T> represents a sequence
        - The query is NOT executed immediately
        - It runs only when we iterate over it (for example, using foreach)

        Therefore, IEnumerable<T> does NOT have:
        - Length (array property)
        - Count (list property)

        In other words, the query result variable "averageQuery" is NOT an "array" or a "list" 
        so we cannot use the properties "Length" and "Count" perspectively


        <Enumerable> Methods:
        *********************
        Sometimes we want to:
        - Execute the query immediately
        - Store the results in memory
        - Work with a concrete collection (Array or List)

        HOW?
        ****
        > We can use of parentheses around the query expression before the call to the Enumerable method "Enumerable.Count method". 
        > we can can also use a new variable to store the concrete result.
        

        For that purpose, LINQ provides methods such as:
        ************************************************

        - .ToList() => To get a List
        
        - .ToArray() => To get an Array

        These methods FORCE immediate execution of the query.
        They are called "materialization" methods because they
        materialize (convert) the sequence into a real collection.       
        */

        /* 
        Examples about using .ToArray() and .ToList() methods
        */

        // Example using .ToArray():
        int[] resultArray =
            (from score in scoresArray
             where score >= 90
             select score).ToArray(); // Warning: Collection initialization can be simplified
        /*
        > The LINQ query executes immediately
        > The filtered results are collected
        > A new integer array is created
        > The results are stored inside that array
        */

        // Now we can use array-specific properties:
        Console.WriteLine("\nUsing .ToArray():");
        Console.WriteLine($"Array Length: {resultArray.Length}");

        // Example using .ToList():
        List<int> resultList =
            (from score in scoresArray
             where score >= 90
             select score).ToList(); // Warning: Collection initialization can be simplified
        /*
        > The LINQ query executes immediately
        > The results are stored in a new List<int>
        > We now have access to List methods and properties
        */

        // Literal List: take the query result variable and make it simple list:
        List<int> myAvgList = averageQuery.ToList();

        // Literal Array: Or to take the query result variable and make it simple array:
        int[] myArrList = averageQuery.ToArray();

        // Now we can use list-specific properties:
        Console.WriteLine("\nUsing .ToList():");
        Console.WriteLine($"List Count: {resultList.Count}");

        // Example using .Count(): using the "averages" list
        int highAvgCount = (
            from avg in averages
            where avg >= 90
            select avg
        ).Count();

        Console.WriteLine($"\nHigh Averages (90+): {highAvgCount}\n");

        // Demonstrating Deferred Execution:
        // *********************************
        IEnumerable<int> deferredQuery =
            from score in scoresArray
            where score >= 90
            select score;

        // Modify original array BEFORE iterating
        scoresArray[0] = 50;

        Console.WriteLine("\nDeferred Execution Example:");
        foreach (var score in deferredQuery)
        {
            Console.Write(score + " ");
        }

        Console.WriteLine();

        Console.WriteLine("\n\nLINQ with Lambda expression:");

        /*
        LINQ with Lambda expression:
        ****************************

        We used LINQ Query Expression Syntax:

            from score in scoresArray
            where score >= 90
            select score;

        The C# compiler translates query syntax into method calls.

        These method calls are known as:
        > Standard Query Operators

        The methods examples:
        - Where()
        - Select()
        - OrderBy()
        - Count()
        - Max()
        - Average()
        - GroupBy()
        - Join()

        These methods exist in the "System.Linq" namespace.
    
        Query Syntax vs Method Syntax:
        ******************************
        - Both syntaxes are semantically identical (same result).
        - Query syntax is often easier to read (especially for beginners).
        - Method syntax is more flexible.
        - Some operations MUST use method syntax:
            > Count()
            > Max()
            > Average()
            > First()
            > etc.

    T   Therefore, it is important to understand both styles.
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/write-linq-queries
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/write-linq-queries#lambda-expressions
        */

        // Lambda Syntax Example #1 — Very Basic (Where):
        // **********************************************
        /*
        Lambda Syntax (Method Syntax) Example #1
        Filtering values greater than or equal to 90
        Instead of this long syntax:

        IEnumerable<int> scoresQuery =
                from score in scoresArray 
                where score >= 90
                select score;
                
        we can use the "Lambda Expression":
        */
        IEnumerable<int> lambdaQuery1 =
            scoresArray.Where(score => score >= 90);
        /*
        > Where() is a LINQ extension method
        > score => score >= 90 is the "Lambda Expression"
        > "=>" is called the "Lambda Operator"
        > It means: "goes to" or "returns"
        */

        Console.WriteLine("\nLambda Example #1:");
        foreach (var score in lambdaQuery1)
        {
            Console.Write(score + " ");
        }

        // Lambda Syntax Example #2 — Filtering + Ordering:
        // ************************************************
        /*
        Filtering AND ordering

        IEnumerable<int> scoresQuery =
                from score in scoresArray
                where score >= 90
                orderby score descending
                select score;
        */
        IEnumerable<int> lambdaQuery2 =
            scoresArray
                .Where(score => score >= 80)
                .OrderByDescending(score => score);
        /*
        Notes:
        ******
        - We can chain methods
        - Each method returns IEnumerable<T>
        - This is called "Method Chaining"
        */

        Console.WriteLine("\n\nLambda Example #2:");
        foreach (var score in lambdaQuery2)
        {
            Console.Write(score + " ");
        }

        // Lambda Syntax Example #3 — Projection (int => string):
        // ******************************************************
        // Projection from int to string
        IEnumerable<string> lambdaQuery3 =
            scoresArray
                .Where(score => score >= 90)
                .Select(score => $"Score value is: {score}");

        Console.WriteLine("\n\nLambda Example #3:");
        foreach (var text in lambdaQuery3)
        {
            Console.WriteLine(text);
        }
        /*
        Notes:
        ******
        - Select() transforms the data
        - The type changes from "int" to "string"
        */
        
        // Lambda Syntax Example #4 — Count (Must Use Method Syntax):
        // **********************************************************
        // Counting elements (must use method syntax)
        
        int countHighScores =
            scoresArray.Count(score => score >= 90);
        /*
        Note:
        *****
        - Query syntax CANNOT directly express Count like this
        - Count() is a method call
        - This executes immediately (Immediate Execution)
        */
        Console.WriteLine($"\nHigh Scores Count: {countHighScores}");

        /*
        LAMBDA EXPRESSION SUMMARY:
        **************************

        Query Syntax:
        - Easier to read
        - Looks similar to SQL
        - Good for beginners

        Method Syntax:
        - Uses Lambda Expressions
        - More powerful and flexible
        - Required for some operations (Count, Max, Average, ...)

        Both produce the same result.
        The compiler converts query syntax into method syntax internally.

        Link: https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/write-linq-queries
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/write-linq-queries#lambda-expressions
        */
    } // End of Main method
} // End of Program class

/*
NOTES TO REMEMBER:
******************
- LINQ works with any collection that implements "IEnumerable<T>" interface
- LINQ queries return IEnumerable<T> by default
- LINQ uses Deferred Execution
- Query expressions describe WHAT we want
- The query runs only when we iterate over it
- To force immediate execution, we can use:
    > .ToList()
    > .ToArray()
*/