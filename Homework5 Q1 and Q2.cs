namespace Homework5Q2;

class Program
{
    static void Main()
    {
        // Q1
        Console.WriteLine("Q1:");
        int num1 = GetInput("Enter the first integer:");
        int num2 = GetInput("Enter the second integer:");
        int resultQ1 = GetLargest(num1, num2);
        Console.WriteLine($"The largest number from Q1 is: {resultQ1}");

        // Q2
        Console.WriteLine("\nQ2:");
        int num3 = GetInput("Enter the third integer:");
        int num4 = GetInput("Enter the fourth integer:");
        int resultQ2 = GetLargest(num1, num2, num3, num4);
        Console.WriteLine($"The largest number from Q2 is: {resultQ2}");
    }

    // Q1 method to get the largest among two integers
    static int GetLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // Q2 method to get the largest among four integers using Q1 method
    static int GetLargest(int a, int b, int c, int d)
    {
        int max1 = GetLargest(a, b); 
        int max2 = GetLargest(c, d); 
        return GetLargest(max1, max2); 
    }

    // Method to get integer input from the user
    static int GetInput(string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}