# csharp-intro
A User friendly introduction to programming with C# using VS Code.

**Notice that it's just first part of C# Introductory Course, the second part will be added later.**

# About C#:
C# is a modern (beginner-friendly) programming language used to build real applications such as websites, mobile apps, games, and cloud-based systems. It is part of the .NET platform and works on Windows, macOS, and Linux. Because C# is free, open source, and widely used in the industry, it is a strong choice for learning programming and starting a career in software development.

C# programs run on the .NET platform. We can write and run C# using the Microsoft's full IDE (Integrated Development Environment) **Visual Studio**, or by using a lighter editor like **Visual Studio Code** Desktop or the cloud version of GitHub (Codespaces) as we are doing in this repo. 

Visual Studio includes many built-in tools and is commonly used for large projects, while Visual Studio Code is simpler, faster, and works exactly the same way on Windows, macOS, and Linux. In this repository, C# is written and run using Visual Studio Code together with the .NET command-line tools.

# starting with .NET CLI
- Run Windows Terminal (Powershell), naviagte to your folder, or in GitHub codespaces, just the Terminal window.
- using the "dotnet" as a command line tool for CLI (Command Line Interface)

> **Running this:**

    ```
    dotnet
    ```

will show this:

   ```
   Usage: dotnet [options]
   Usage: dotnet [path-to-application]

   Options:
   -h|--help         Display help.
   --info            Display .NET information.
   --list-sdks       Display the installed SDKs.
   --list-runtimes   Display the installed runtimes.

   path-to-application:
   The path to an application .dll file to execute.
   PS C:\Repos\beginning-c#> dotnet

   Usage: dotnet [options]
   Usage: dotnet [path-to-application]

   Options:
   -h|--help         Display help.
   --info            Display .NET information.
   --list-sdks       Display the installed SDKs.
   --list-runtimes   Display the installed runtimes.

   path-to-application:
   The path to an application .dll file to execute.
   ```

---


 > **Running this:**
    ```
    dotnet new
    ```

will show this (Was updated based on the Dotnet version 10):
```
Welcome to .NET 10.0!
---------------------
SDK Version: 10.0.100

Telemetry
---------
The .NET tools collect usage data in order to help us improve your experience. It is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry

----------------
Installed an ASP.NET Core HTTPS development certificate.
To trust the certificate, run 'dotnet dev-certs https --trust'
Learn about HTTPS: https://aka.ms/dotnet-https

----------------
Write your first app: https://aka.ms/dotnet-hello-world
Find out what's new: https://aka.ms/dotnet-whats-new
Explore documentation: https://aka.ms/dotnet-docs
Report issues and find source on GitHub: https://github.com/dotnet/core
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
--------------------------------------------------------------------------------------
The 'dotnet new' command creates a .NET project based on a template.

Common templates are:
Template Name        Short Name  Language    Tags                   
-------------------  ----------  ----------  -----------------------
Blazor Web App       blazor      [C#]        Web/Blazor/WebAssembly 
Class Library        classlib    [C#],F#,VB  Common/Library         
Console App          console     [C#],F#,VB  Common/Console         
MSTest Test Project  mstest      [C#],F#,VB  Test/MSTest/Desktop/Web
Windows Forms App    winforms    [C#],VB     Common/WinForms        
WPF Application      wpf         [C#],VB     Common/WPF             

An example would be:
   dotnet new console

Display template options with:
   dotnet new console -h
Display all installed templates with:
   dotnet new list
Display templates available on NuGet.org with:
   dotnet new search web
```

# Preparing Codespaces on Github for C# Application:
For more details you can refer to my ReadME file for **[UML and C#](https://github.com/anmarjarjees/uml-csharp/blob/main/README.md)** repo.

## Starting with our applications:
Creating a **"Console App"** or what's called a text mode application just for learning the essentials of C#. This application will run inside the terminal (VS code, VS IDE, or any other C# Editor). 

**IMPORTANT NOTES About Folders/Projects and File Navigation:**
 - For every C# topic, we will create a new **Console App** project.**
 - Each directory/folder starting with number referring to the sequence of the topics


## Required C# Extension:
We can simply search for C# in the "Extensions Marketplace", recommended to chose the *Microsoft Extension*
- C# Dev Kit for Visual Studio Code
- C# Base language support for C#

## Preparing the each project (topic) folder/directory:
There are two different ways:
1. Using **Using VS Code Commands** as clearly explained in my repo **[UML and C#](https://github.com/anmarjarjees/uml-csharp/blob/main/README.md)** repo.

2. Using the **Terminal Window**
   - Make (Create) a new directory based on your project name:
      ```
      mkdir 01.intro
      ```
      
      **NOTES:**

         > Linux (Codespaces Terminal) => mkdir directory-name
         > Windows => mkdir directory-name OR md directory-name

   - Call the directory (Be inside the directory):
      ```
      cd 01.intro
      ```
   - For Demo/Learning purpose (Optional), running this command again:
      ```
      dotnet new
      ```
      will show:
      ```
      The 'dotnet new' command creates a .NET project based on a template.

      Common templates are:
      Template Name        Short Name  Language    Tags                   
      -------------------  ----------  ----------  -----------------------
      Blazor Web App       blazor      [C#]        Web/Blazor/WebAssembly 
      Class Library        classlib    [C#],F#,VB  Common/Library         
      Console App          console     [C#],F#,VB  Common/Console         
      MSTest Test Project  mstest      [C#],F#,VB  Test/MSTest/Desktop/Web
      Windows Forms App    winforms    [C#],VB     Common/WinForms        
      WPF Application      wpf         [C#],VB     Common/WPF             

      An example would be:
         dotnet new console

      Display template options with:
         dotnet new console -h
      Display all installed templates with:
         dotnet new list
      Display templates available on NuGet.org with:
         dotnet new search web
      ```
   - Run this command inside the directory using the short name "console" as shown in the table above of the Common templates using just the short name "console" :-):
      ```
      dotnet new console
      ```

      - The command will generate the following (Also result was updated based on the Dotnet version 10):
         ```
         The template "Console App" was created successfully.

         Processing post-creation actions...
         Restoring /workspaces/csharp-intro/01.intro/01.intro.csproj:
         Restore succeeded.
         ```
      - Previously, used to be like this:
         ```
         Mode                 LastWriteTime         Length Name
         ----                 -------------         ------ ----
         d-----        2024-08-26  12:58 PM                obj
         -a----        2024-08-26  12:58 PM            249 intro.csproj
         -a----        2024-08-26  12:58 PM            105 Program.cs
         ```
      - The project folder will contain these initial files/folder:
         - 01.intro.csproj => the project file (notice that project file name is according to the folder name)
         - Program.cs => the main program (entry point) to run our application (our C# code and .cs for csharp)
         - obj folder => a folder related to the system and project settings (usually ignored)

   - To run the code:
      ```
      dotnet run
      ```
   - As C# is a compiled language the command will compile the application and generate the default text:
      ```
      Hello, World!
      ``` 
      **NOTE: the run command will generate a "bin" folder (Binary Folder), the folder where is the result application is set**
        

      **Notice that you can start/run your VS code (on computer only) within your current active folder using:**
      ```
      code .
      ```

---

**IMPORTANT TIP:**

By default, the command:
   ```
   dotnet new console
   ```
generates a **"**Program.cs"** file that uses **top-level statements** (introduced in .NET 6).

If you prefer the **traditional structure** with an explicit Program class and Main() method, you can use:
   ```
   dotnet new console --use-program-main
   ```
---

For more commands about linux, review my repo:
**[Linux CLI](https://github.com/anmarjarjees/linux-cli)**

### Running our Applications Quick Recap and Tips:
Run our application:
- Click the play/run button
- Or using this command in the terminal:
   ```
   dotnet run 
   ```

- Or using the hotkeys:
   - F5 => for Run and Debug
   - CTRL + F5 => for just running

Don't forget the CTRL + ` to toggle the terminal window. You can use the command "clear" to clear the window

VS Code will show the most commonly used method with "star" symbol in the intelesecen window

# Resources:
- dot.net => then "Explore learning portal"
- https://learn.microsoft.com/en-us/dotnet/csharp/
- https://code.visualstudio.com/docs/csharp/get-started

# Copilot AI Assistance:
We can enable/disable Copilot Inline Suggestions for code and comments:
   - Open VS Code Command Palette => CTRL + SHIFT + P
   - Select Copilot: **Enable Inline Suggestions** OR Toggle between enable/disable inline suggestions

# Credits, References, and Resources:
- Learn .NET:
    - https://dotnet.microsoft.com/en-us/learn 
- Learn to code C#:
    - https://dotnet.microsoft.com/en-us/learntocode
- .NET documentation:
    - https://learn.microsoft.com/en-us/dotnet/
- C# language documentation:
   - https://learn.microsoft.com/en-us/dotnet/csharp/
