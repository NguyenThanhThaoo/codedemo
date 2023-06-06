using System;

public class Program
{
    public static void Main()
    {
        // Print a welcome message
        Console.WriteLine("Welcome to the Clean Code Example!");

        // Array of numbers
        int[] numbers = { 5, 10, 15, 20, 25 };

        // Calculate the sum of the numbers
        int sum = CalculateSum(numbers);

        // Print the result
        Console.WriteLine("The sum of the numbers is: " + sum);
    }

    // Method to calculate the sum of an array of numbers
    public static int CalculateSum(int[] numbers)
    {
        // Check if the array is null or empty
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The numbers array must not be null or empty.");
        }

        int sum = 0;

        // Loop through the numbers and calculate the sum
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum; // Return the sum
    }
}
