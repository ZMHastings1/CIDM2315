namespace Homework2;
//Program to input grade letters
class Program
{
    static void Main(string[] args)
    {
        //Console line to prompt the user to enter a grade
       Console.Write("Enter a letter grade (A, B, C, D, F): ");
        char grade = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); 

        int gpaPoints;

        //If statements for the different letter grades
        if (grade == 'A')
        {
            gpaPoints = 4;
        }
        else if (grade == 'B')
        {
            gpaPoints = 3;
        }
        else if (grade == 'C')
        {
            gpaPoints = 2;
        }
        else if (grade == 'D')
        {
            gpaPoints = 1;
        }
        else if (grade == 'F')
        {
            gpaPoints = 0;
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
            return; // Exit the program if the letter grade is incorrect
        }

        Console.WriteLine($"GPA Points for grade {grade}: {gpaPoints}");
    }
}

