// Write a C# program to read 'n' digit integer(e.g. 123 or 1234 or 12345) and compute the sum of every digit in the integer read. Print the sum of all digits of the integer.
namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + (n * (n + 1) / 2));
        }
    }
}