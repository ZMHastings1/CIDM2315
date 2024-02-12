namespace Homework4;

class Program
{//Program to take two number inputs and display the largest number
    static void Main(string[] args)
    {
        Console.WriteLine("------Question 1-------");
        // Calling the method and printing the result
        Console.WriteLine("Enter two numbers:");
        Console.Write("First number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        double result = FindLargest(num1, num2);
        Console.WriteLine($"The largest number is: {result}");
    }

    // Method to find the largest number among two numbers
    static double FindLargest(double num1, double num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

    
}