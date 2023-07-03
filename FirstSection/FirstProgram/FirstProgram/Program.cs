namespace System;

public class Program
{
    public static void Main()
    {
        int age = 30;
        string name = "Raul";
        string job = "developer";

        // 1. String concatenation
        Console.WriteLine("string concat");
        Console.WriteLine("Hello, my name is " + name + " my age is " + age);

        // 2. String formatting
        Console.WriteLine("String Formatting");
        // Depending on the index, it will be required as an additional value
        Console.WriteLine("Hello my name is {0}, I am {1} years old, I am a {2}", name, age, job);


        // 3. String interp
        Console.WriteLine("String interpolation");
        Console.WriteLine($"Hello, my name is {name}, I am {age} old, and I am a {job}");

        // 4. Verbatim strings
        Console.WriteLine("Verbatim Strings");
        // It is used to ignore any "escape" route, perfect to be used on routes
        Console.WriteLine(@"E:\Cursos\csharpMasterClass\FirstSection\FirstProgram");

        // Backslash before quotes to ignore any special character
        // Backslash used as escape character
        // Backslash \n used to add a new line
        string s1 = "This is a\"string\"with\na backslash \\ and a colon :";
        Console.WriteLine(s1);


        Challenge1();


    }

    public static void Challenge1()
    {
        string myString;
        Console.WriteLine("Please enter you name and press enter: ");
        myString = Console.ReadLine();
        string myUpperString = myString.ToUpper();
        string myLowerString = myUpperString.ToLower();


        Console.WriteLine(myUpperString);
        Console.WriteLine(myLowerString);
        string myStringTrim = myString.Trim();
        Console.WriteLine(myStringTrim);
        string subStringmyString = myString.Trim().Substring(4);
        Console.WriteLine(subStringmyString);



    }
}