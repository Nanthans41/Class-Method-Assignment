using System;

// This class contains the methods required for the assignment.
public class MathOperations
{
    // This is a void method because it does not return a value.
    // It accepts an integer and divides that integer by 2.
    // The result is displayed directly to the console.
    public void DivideByTwo(int number)
    {
        // Divide the number passed into the method by 2.
        double result = number / 2.0;

        // Display the result to the user.
        Console.WriteLine("The number divided by 2 is: " + result);
    }

    // This method demonstrates the use of output parameters.
    // The "out" parameters allow this method to return multiple values.
    public void GetResults(int number, out int doubled, out int tripled)
    {
        // Calculate twice the value of the number.
        doubled = number * 2;

        // Calculate three times the value of the number.
        tripled = number * 3;
    }

    // This method is an overloaded version of Add.
    // It accepts two integers and returns their sum.
    public int Add(int number1, int number2)
    {
        // Add the two integers together and return the result.
        return number1 + number2;
    }

    // This is another version of the Add method.
    // It has the same name but accepts three integers instead of two.
    // This demonstrates method overloading.
    public int Add(int number1, int number2, int number3)
    {
        // Add all three integers together and return the result.
        return number1 + number2 + number3;
    }
}

// This class is declared static because it contains a static method
// and does not need to be instantiated to use its functionality.
public static class StaticHelper
{
    // This static method displays a message to the console.
    public static void DisplayMessage()
    {
        // Display a message explaining that the static class is being used.
        Console.WriteLine("The static helper class is working.");
    }
}

// The Program class contains the Main method where the application begins.
class Program
{
    // Main is the starting point of the console application.
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class.
        MathOperations math = new MathOperations();

        // Ask the user to enter a number.
        Console.Write("Enter a number: ");

        // Read the user's input from the keyboard as text.
        string input = Console.ReadLine();

        // Convert the user's input from a string into an integer.
        int number = Convert.ToInt32(input);

        // Call the DivideByTwo method and pass the user's number to it.
        math.DivideByTwo(number);

        // Declare variables that will receive values from the output parameters.
        int doubled;
        int tripled;

        // Call the GetResults method.
        // The "out" keyword allows the method to assign values to these variables.
        math.GetResults(number, out doubled, out tripled);

        // Display the values returned through the output parameters.
        Console.WriteLine("The number multiplied by 2 is: " + doubled);
        Console.WriteLine("The number multiplied by 3 is: " + tripled);

        // Call the two-parameter version of the overloaded Add method.
        int sumTwoNumbers = math.Add(number, 10);

        // Display the result of adding two numbers.
        Console.WriteLine("The number plus 10 is: " + sumTwoNumbers);

        // Call the three-parameter version of the overloaded Add method.
        int sumThreeNumbers = math.Add(number, 10, 20);

        // Display the result of adding three numbers.
        Console.WriteLine("The number plus 10 plus 20 is: " + sumThreeNumbers);

        // Call the method from the static class.
        // A static class does not need to be instantiated.
        StaticHelper.DisplayMessage();

        // Pause the application so the user can see the results
        // before the console window closes.
        Console.WriteLine("\nPress any key to exit.");

        // Wait for the user to press a key.
        Console.ReadKey();
    }
}
