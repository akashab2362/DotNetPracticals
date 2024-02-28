using System;

public interface IPrintable
{
    void Print();
}

public class Employee : IPrintable
{
    private string name;
    private int age;
    private static int employeeCount;

    // Public constructor
    public Employee(string name, int age)
    {
        this.name = name;
        this.age = age;
        employeeCount++;
    }

    // Private constructor
    private Employee()
    {
        // This constructor can be used only within the class
    }

    // Static constructor
    static Employee()
    {
        employeeCount = 0;
    }

    // Method overriding
    public virtual void print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    // Method with new keyword
    public new void print(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    // Implementing the interface method
    public void Print()
    {
        Console.WriteLine($"Employee: {name}, Age: {age}");
    }

    // Static method to get employee count
    public static int GetEmployeeCount()
    {
        return employeeCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("John", 30);
        emp.print(); // Calls overridden print method
        emp.print("Hello"); // Calls method with new keyword
        emp.Print(); // Calls interface method

        int count = Employee.GetEmployeeCount();
        Console.WriteLine($"Total Employees: {count}");
    }
}
