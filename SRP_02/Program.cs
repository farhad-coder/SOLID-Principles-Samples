class Program
{
    static void Main(string[] args)
    {
        
    }
}

/*
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    // محاسبه حقوق کارمند
    public double CalculateSalary()
    {
        return Salary * 1.1; // فرضا حقوق با ۱۰٪ افزایش
    }

    // نمایش اطلاعات کارمند
    public void PrintEmployeeDetails()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
    }
}
*/

// کلاس مسئول ذخیره اطلاعات کارمند
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
}

// کلاس مسئول محاسبه حقوق
public class SalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.Salary * 1.1;
    }
}

// کلاس مسئول نمایش اطلاعات کارمند
public class EmployeePrinter
{
    public void PrintEmployeeDetails(Employee employee)
    {
        Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
    }
}
