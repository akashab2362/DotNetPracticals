using System;

public class PalindromeChecker
{
    // Recursive function to check if a number is palindrome
    public static bool IsPalindromeRecursive(int num)
    {
        return IsPalindromeHelper(num, 0, num.ToString().Length - 1);
    }

    private static bool IsPalindromeHelper(int num, int start, int end)
    {
        if (start >= end)
            return true;

        if (num.ToString()[start] != num.ToString()[end])
            return false;

        return IsPalindromeHelper(num, start + 1, end - 1);
    }

    // Iterative function to check if a number is palindrome
    public static bool IsPalindromeIterative(int num)
    {
        string numStr = num.ToString();
        int left = 0;
        int right = numStr.Length - 1;

        while (left < right)
        {
            if (numStr[left] != numStr[right])
                return false;
            left++;
            right--;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it's a palindrome:");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPalindromeRecursive = IsPalindromeRecursive(number);
        bool isPalindromeIterative = IsPalindromeIterative(number);

        Console.WriteLine($"{number} is {(isPalindromeRecursive ? "" : "not ")}a palindrome (recursive approach).");
        Console.WriteLine($"{number} is {(isPalindromeIterative ? "" : "not ")}a palindrome (iterative approach).");
    }
}
