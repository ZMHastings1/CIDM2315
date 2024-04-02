namespace Homework9;

public class Student
{
    public int studentID;
    public string studentName;

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        this.studentID = id;
        this.studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create 4 students
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        // Create gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        // Check if "Tom" exists in the gradebook, if not, add with GPA 3.3
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // Calculate average GPA
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;

        // Print average GPA
        Console.WriteLine($"Average GPA: {averageGPA}");

        // Print students whose GPA is greater than the average GPA
        Console.WriteLine("Students with GPA greater than the average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.studentName) && gradebook[student.studentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
