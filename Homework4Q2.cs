namespace Homework4Q2;

class Program
{
    static void Main(string[] args)
    {
        //Program to ask the user to input a number and right or left to display a triangle right or left
        Console.WriteLine("--------Question 2--------");
        Console.Write("Enter an integer number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        
        Console.Write("Enter the shape (left or right): ");
        string shape = Console.ReadLine();

        
        Console.WriteLine($"N = {N}, Shape = {shape}");

        
        if (shape.ToLower() == "left")
        {
            
            PrintLeftTriangle(N);
        }
        else if (shape.ToLower() == "right")
        {
            
            PrintRightTriangle(N);
        }
        else
        {
            
            Console.WriteLine("Invalid shape input. Please enter 'left' or 'right'.");
        }
    }

    // Method to print left triangle
    static void PrintLeftTriangle(int N)
    {
        for (int i = 1; i <= N; i++) 
        {
            for (int j = 0; j < i; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }

    // Method to print right triangle
    static void PrintRightTriangle(int N)
    {
        for (int i = 1; i <= N; i++) 
        {
            for (int j = N - i; j > 0; j--) 
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i; k++) 
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}
