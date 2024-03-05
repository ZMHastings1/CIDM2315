namespace Homework6;

// Professor class implementation
public class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    // Constructor to initialize professor's attributes
    public Professor(string name, string course, double salary)
    {
        this.profName = name;
        this.classTeach = course;
        this.salary = salary;
    }

    // Method to set professor's salary
    public void SetSalary(double salary_amount)
    {
        this.salary = salary_amount;
    }

    // Method to get professor's salary
    public double GetSalary()
    {
        return this.salary;
    }

    // Method to get professor's name
    public string GetName()
    {
        return this.profName;
    }

    // Method to get professor's class
    public string GetCourse()
    {
        return this.classTeach;
    }
}

// Student class implementation
public class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    // Constructor to initialize student's attributes
    public Student(string name, string course, double grade)
    {
        this.studentName = name;
        this.classEnroll = course;
        this.studentGrade = grade;
    }

    // Method to set student's grade
    public void SetGrade(double newGrade)
    {
        this.studentGrade = newGrade;
    }

    // Method to get student's grade
    public double GetGrade()
    {
        return this.studentGrade;
    }

    // Method to get student's name
    public string GetName()
    {
        return this.studentName;
    }

    // Method to get student's enrolled class
    public string GetCourse()
    {
        return this.classEnroll;
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Creating 2 Professors
        Professor professor1 = new Professor("Alice", "Java", 9000);
        Professor professor2 = new Professor("Bob", "Math", 8000);

        // Creating 2 Students
        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        // Printing details for each professor
        Console.WriteLine("Details for Professors:");
        Console.WriteLine($"Professor 1: Name - {professor1.GetName()}, Teaches - {professor1.GetCourse()}, Salary - {professor1.GetSalary()}");
        Console.WriteLine($"Professor 2: Name - {professor2.GetName()}, Teaches - {professor2.GetCourse()}, Salary - {professor2.GetSalary()}");

        // Printing details for each student
        Console.WriteLine("\nDetails for Students:");
        Console.WriteLine($"Student 1: Name - {student1.GetName()}, Enrolled in - {student1.GetCourse()}, Grade - {student1.GetGrade()}");
        Console.WriteLine($"Student 2: Name - {student2.GetName()}, Enrolled in - {student2.GetCourse()}, Grade - {student2.GetGrade()}");

        // Calculating and printing the difference in salary between the two professors
        double salaryDifference = Math.Abs(professor1.GetSalary() - professor2.GetSalary());
        Console.WriteLine($"\nDifference in salary between the two professors: {salaryDifference}");

        // Calculating and printing the total grade of Lisa’s Java course and Tom’s Math course
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"Total grade of Lisa’s Java course and Tom’s Math course: {totalGrade}");
    }
}