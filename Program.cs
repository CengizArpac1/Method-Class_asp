using System;

namespace MethodDemo
{
    // This class demonstrates a method with two integer parameters
    public class Calculator
    {
        // This method performs division on the first parameter and displays the second parameter
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Divide the first number by 4 and store the result
            double result = (double)firstNumber / 4;
            
            // Display both the calculation result and the second parameter
            Console.WriteLine($"First number {firstNumber} / 4 = {result}");
            Console.WriteLine($"Second number is: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calc = new Calculator();

            // Call the method using positional parameters
            Console.WriteLine("Calling method with positional parameters:");
            calc.ProcessNumbers(12, 24);

            Console.WriteLine("\nCalling method with named parameters:");
            // Call the method using named parameters
            calc.ProcessNumbers(firstNumber: 16, secondNumber: 32);

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}