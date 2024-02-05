namespace Homework3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------Question 1--------");
            //Program to take an input integer and say if it is prime or not prime
            bool isPrime = true;
            Console.WriteLine("Input an integer: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(input + " is Prime ");
            }
            else
            {
                Console.WriteLine(input + " is non-prime ");
            }

            Console.WriteLine("--------Question 2---------");
            //Program to write a pattern of '#'
            Console.WriteLine("Assign an int value to N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------Question 3--------");

            // Program to write a pattern of '*'
            Console.WriteLine("Assign an int value to N: ");
            int x = int.Parse(Console.ReadLine());
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (row >= col)
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
