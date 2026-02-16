// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Converting the file to a full C# template for better context understanding.
using System;

/* 
Notice below, with the "namespace" block, we added the opening and closing curly braces for the "namespace" block,
so we can write our code in a more traditional way with a "class" and a "main method".
*/
namespace NumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers in C#");
            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp

            // Working with Integers:
            // declaration of variables of type "int" and assigning values to them
            int a = 20;
            int b = 7;

            /*
            Default Values of Data Types:
            *****************************
            In C#, when we declare a variable without initializing it, it will have a default value based on its data type. 
            For example:  
             > default value of int is 0
             > default value of double is 0.0
             > default value of bool is false,
             > default value of char is '\0' (null character)
            */

            /* 
            - for subtraction
            * for multiplication
            / for division
            * for multiplication
             */
            int c = a + b; // Algebra Formula
            Console.WriteLine(c);

            /*
            NOTE:
            Integer division always produces an integer result, 
            even if the result must include a decimal or fractional portion in real math,
            but in C# decimal pints will be truncated with integers

            Order Precedence => Order of operations:
            ****************************************
            In C#, the order of operations for arithmetic expressions follows the standard mathematical rules,
            which is often remembered using the acronym PEDMAS or BEDMAS:
             > Parentheses (Brackets)
             > Exponents
             > Multiplication and Division (from left to right)     
             > Addition and Subtraction (from left to right)       
            */

            c = 8;
            int d = (a + b) / c; // (20 + 7) / 8 = 27 / 8 = 3.375 => truncated to 3 because of integer division
            Console.WriteLine(d); // Output: 3

            // To get the remainder by using the "remainder operator" also known as the "modulo operator" => The "%" character:
            int quotient = (a + b) / c; // Integer division
            int remainder = (a + b) % c;  // Remainder
            Console.WriteLine($"quotient: {quotient}"); // Output: quotient: 3
            Console.WriteLine($"remainder: {remainder}");   // Output: remainder: 3

            int num1 = 10;
            int num2 = 5;
            int result = num1 / num2; // Integer division
            Console.WriteLine($"The result of {num1} divided by {num2} is {result}"); // Output: The result of 10 divided by 3 is 3

            result = num1 % num2; // Remainder
            Console.WriteLine($"The remainder of {num1} divided by {num2} is {result}"); // Output: The remainder of 10 divided by 5 is 0 
            /*
            So we can use the modulo operator to find out if a number is even or odd:
            if the result of num % 2 is 0, then the number is even, otherwise, it's odd.
            */

            /*
            C# Numbers:
            ************
            In C#, we have different types of numbers, such as:
             > int: for whole numbers (integers)
             > double: for floating-point numbers (numbers with decimal points)
             > float: for single-precision floating-point numbers
             > decimal: for high-precision decimal numbers (often used in financial calculations)
             > long: for larger whole numbers (integers)
             > short: for smaller whole numbers (integers)
             > byte: for very small whole numbers (integers)
            */

            // int x = 12345678901;
            /* 
            Error: Cannot implicitly convert type 'long' to 'int'. An explicit conversion exists (are you missing a cast?)
            */

            /* 
            "int" type has minimum and maximum limits:
            ******************************************
            to find out the minimum and maximum values of the "int" type, we can use the "int.MinValue" and "int.MaxValue" properties:
            link: https://learn.microsoft.com/en-us/dotnet/api/system.int32.minvalue
            link: https://learn.microsoft.com/en-us/dotnet/api/system.int32.maxvalue  
            */

            int max = int.MaxValue; // 2147483647
            int min = int.MinValue; // -2147483648 
            Console.WriteLine($"The range of integers is {min} to {max}");
            // The range of integers is -2147483648 to 2147483647


            /* 
            If a calculation produces a value that exceeds the maximum or the minium limit, 
            We will have an "underflow" or "overflow" condition. 
            */
            int test = max + 3;
            Console.WriteLine($"An example of overflow: the output is {test}");
            /* 
            NOTE:
            The answer is a very large negative number 
            because an overflow "wraps around" from the largest possible integer value to the smallest.
             */

            /* 
            "double" and "float":
            *********************
            "double": The double numeric type represents a double-precision floating point number. 

            double: Double-precision 
            float: Single-Precision
            On modern computers, it is more common to use double precision than single precision numbers. 
            Single precision numbers are declared using the float keyword.
            */

            /*
            The "double" type:
            The double numeric type represents a double-precision floating point number.
            */

            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

            /*
            The "decimal" type:
            The decimal type has a smaller range but greater precision than double
            */
            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;
            Console.WriteLine($"The range of decimal is {minDecimal} to {maxDecimal}");

            decimal value1 = 1.0M;
            decimal value2 = 3.0M;

            // decimal value3 = 10.0;
            // Console.WriteLine(typeof(value3)); // Output: System.Double 
            // Error: error CS0664: Literal of type double cannot be implicitly converted to type 'decimal'; use an 'M' suffix to create a literal of this type
            // C# Cannot implicitly convert type 'double' to 'decimal'. An explicit conversion exists

            double value3 = 10.0M; // Corrected to use decimal literal and assign to double

            Console.WriteLine(typeof(value2)); // Output: System.Decimal


            /*
            Note:
             > The decimal type has a smaller range but greater precision than double.
             > The decimal type is particularly useful for financial calculations where precision is important, 
               as it can represent decimal numbers more accurately than double.
             > The double type is a double-precision floating-point type that can represent a wider range of values,
               but may not be as precise for certain decimal numbers, especially those that cannot be represented exactly
             > The "M" suffix indicates that the number is a decimal literal, indicates that a constant should use the decimal type
               which allows us to use the decimal type for our calculations.
               Otherwise, the compiler would treat the numbers as double by default, and we would lose the precision benefits of using decimal.

             So, when we perform division with the decimal type, we get a more precise result compared to using the double type.
            */
            Console.WriteLine(value1 / value2); // Output: 0.3333333333333333333333333333

            /* 
            Tip:
            Most of the time, we will use "double" for floating-point numbers in C#,
            unless we need high precision for financial calculations, then we will use "decimal"    
            */

            // The "float" type: Using the "f" suffix to indicate a float literal:
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            Console.WriteLine($"The range of float is {minFloat} to {maxFloat}");

            float floatValue = 10.5f; // Using the "f" suffix to indicate a float literal
            Console.WriteLine(floatValue); // Output: 10.5      
            Console.WriteLine(typeof(floatValue)); // Output: System.Single

            /*
            Good to Know:
            **************
            The runtime shows the real underlying .NET type "Output: System.Single", not the C# alias like "float". 
            C# keywords (int, string, float, etc...) are just friendly shortcuts.
            In C#, the default type for floating-point literals is "double"

            Under the hood, they map to:
            ****************************
            C# Keyword: int => Real .NET Type: System.Int32
            C# Keyword: string => Real .NET Type: System.String
            C# Keyword: bool => Real .NET Type: System.Boolean
            C# Keyword: float => Real .NET Type: System.Single
            C# Keyword: double => Real .NET Type: System.Double

            "float" datatype =>	System.Single => Single-precision floating point (32-bit)
            "double" datatype => System.Double => Double-precision floating point (64-bit)

            So:
            > Single for "float" = single precision
            > Double for "double" = double precision
            */

            // Casting:
            // Casting is the process of converting a value from one data type to another.

            // int intValue = 10.7;
            // Error:  error CS0266: Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)

            /*
            We need to use a cast to convert the double value to an int value,
            but we will lose the decimal part of the number, and we will get the integer part only.
            To cast a double to an int, we can use the following syntax:
            
            Please be advised that when we cast a "double" to an "int", 
            the decimal part will be truncated, and we will get the integer part only.
            */
            int intValue1 = (int)10.3; // Output: 10
            int intValue2 = (int)5.2; // Output: 5
            Console.WriteLine(intValue1); // Output: 10
            Console.WriteLine(intValue2); // Output: 5
        }
    }
}

/*
NOTES To Consider:
******************
In C#, numeric literal defaults are:

- Literal: 10 => Default Type: int
- Literal: 10.0 => Default Type: double
- Literal: 10.0f => Default Type: float
- Literal: 10.0m => Default Type: decimal

"double" datatype is the default for decimals in C#:
Because:
    > double is much faster
    > Uses less memory
    > Historically common in scientific computing
    > Most floating-point math in programming uses double

"decimal" datatype is:
    > Slower
    > Larger (128-bit)
    > Designed mainly for financial precision

So C# forces us to explicitly say when we want higher precision, instead of assuming it.
*/