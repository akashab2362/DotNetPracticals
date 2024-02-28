// Read a string from the user and now create a new string from this string by shuffling the position of the first and last characters. Write a C# program for this.
namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string newStr = str.Substring(str.Length - 1) + str.Substring(1, str.Length - 1) + str.Substring(0, 1);
            Console.WriteLine(newStr);
        } 
    }
}