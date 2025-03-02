class Program
{
    static void Main(string[] args)
    {
       
    }
}


/*
public interface IDevice
{
    void Print();
    void Scan();
    void Fax();
}

public class Printer : IDevice
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        throw new NotImplementedException(); // Printer نیازی به اسکن ندارد
    }

    public void Fax()
    {
        throw new NotImplementedException(); // Printer نیازی به فکس ندارد
    }
}

public class Scanner : IDevice
{
    public void Print()
    {
        throw new NotImplementedException(); // Scanner نیازی به چاپ ندارد
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }

    public void Fax()
    {
        throw new NotImplementedException(); // Scanner نیازی به فکس ندارد
    }
}

public class MultiFunctionDevice : IDevice
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }

    public void Fax()
    {
        Console.WriteLine("Faxing...");
    }
}
*/

//****************************************************

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface IFax
{
    void Fax();
}

public class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

public class Scanner : IScanner
{
    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}

public class MultiFunctionDevice : IPrinter, IScanner, IFax
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }

    public void Fax()
    {
        Console.WriteLine("Faxing...");
    }
}

