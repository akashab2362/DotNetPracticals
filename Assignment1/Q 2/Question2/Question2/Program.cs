using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number:");
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be negative.");
            }

            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"The square root of {number} is {squareRoot}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
