namespace System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a string and press enter\n");
        string readInput = Console.ReadLine();
        Console.WriteLine("You have entered {0}", readInput);


        Console.Write("Enter a string and press enter: ");
        int asciiValue = Console.Read();
        Console.WriteLine("ASCII Value is {0}", asciiValue);

        TypeConversion();

    }

    /// <summary>
    /// Type conversion test
    /// </summary>
    public static void TypeConversion()
    {
        float myFloat = 13.37f;
        string myFloatString = myFloat.ToString();
        double myDouble = 100.0234523;
        int myInt = (int)myDouble;
        string myString = myDouble.ToString();

        Console.WriteLine($"Float string: {myFloatString}\n" + $"My double as int: {myInt}\n" + $"My string: {myString}\n");
    }
}