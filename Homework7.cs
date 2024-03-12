namespace Homework7;


public class Customer
{
    private int cus_id; 
    public string cus_name; 
    public int cus_age; 

    // Constructor to initialize customer ID, name, and age
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id; 
        this.cus_name = cus_name; 
        this.cus_age = cus_age; 
    }

    // Method to change customer ID
    public void ChangeID(int new_id)
    {
        cus_id = new_id; 
    }

    // Method to print customer information
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    // Method to compare age with another customer
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older than {objCustomer.cus_name}");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older than {this.cus_name}");
        }
        else
        {
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are of the same age");
        }
    }
}

// Program class
public class Program
{
    // Main method
    public static void Main(string[] args)
    {
        // Create two customers
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        // Print their information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Update customers' IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        // Print their information after ID update
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Compare their age and print the older customer's name
        customer1.CompareAge(customer2);
    }
}
