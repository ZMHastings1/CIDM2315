namespace Homework2_Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");

        // Input the first number
        Console.Write("Please input the first number: ");
        double number1 = Convert.ToInt16(Console.ReadLine());

        // Input the second number
        Console.Write("Please input the second number: ");
        double number2 = Convert.ToInt16(Console.ReadLine());

        // Input the third number
        Console.Write("Please input the third number: ");
        double number3 = Convert.ToInt16(Console.ReadLine());

        // Find the smallest number
        double smallest = FindSmallest(number1, number2, number3);

        // Print the result
        Console.WriteLine($"The smallest number is: {smallest}");
    }

    static double FindSmallest(double number1, double number2, double number3)
    {
        // Compare the three numbers using if statements and return the smallest
        if (number1 <= number2 && number1 <= number3)
        {
            return number1;
        }
        else if (number2 <= number1 && number2 <= number3)
        {
            return number2;
        }
        else
        {
            return number3;
        }
    }
}
