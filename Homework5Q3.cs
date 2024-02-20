namespace Homework5Q3;

class Program
{
    static void Main()
    {
        createAccount();
    }

    // Method to check if the age is greater than or equal to 18
    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return (age >= 18);
    }

    // Method to create an account
    static void createAccount()
    {
        Console.WriteLine("Create an Account:");
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter password again:");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter birth year:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}