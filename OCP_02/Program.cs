/*
public class TaxCalculator
{
    public double CalculateTax(string customerType, double amount)
    {
        if (customerType == "Regular")
        {
            return amount * 0.1; // مالیات ۱۰٪ برای مشتریان عادی
        }
        else if (customerType == "VIP")
        {
            return amount * 0.05; // مالیات ۵٪ برای مشتریان ویژه
        }
        return 0;
    }
}
*/

//*************************************************************

var taxCalculator = new TaxCalculator();
double regularTax = taxCalculator.CalculateTax(new RegularCustomerTax(), 1000);
double vipTax = taxCalculator.CalculateTax(new VipCustomerTax(), 1000);

Console.WriteLine($"Regular Tax: {regularTax}"); // خروجی: 100
Console.WriteLine($"VIP Tax: {vipTax}"); // خروجی: 50


// تعریف یک اینترفیس برای محاسبه مالیات
public interface ITaxCalculator
{
    double CalculateTax(double amount);
}

// مالیات برای مشتریان عادی
public class RegularCustomerTax : ITaxCalculator
{
    public double CalculateTax(double amount)
    {
        return amount * 0.1;
    }
}

// مالیات برای مشتریان VIP
public class VipCustomerTax : ITaxCalculator
{
    public double CalculateTax(double amount)
    {
        return amount * 0.05;
    }
}

// کلاس اصلی برای محاسبه مالیات، بدون نیاز به تغییر در آینده
public class TaxCalculator
{
    public double CalculateTax(ITaxCalculator taxCalculator, double amount)
    {
        return taxCalculator.CalculateTax(amount);
    }
}
// گسترش آسان
public class InternationalCustomerTax : ITaxCalculator
{
    public double CalculateTax(double amount)
    {
        return amount * 0.15; // مالیات ۱۵٪ برای مشتریان خارجی
    }
}


