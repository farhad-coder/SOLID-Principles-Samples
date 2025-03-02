/*
public class PaymentProcessor
{
    private CreditCardPayment creditCardPayment;
    private PayPalPayment payPalPayment;

    public PaymentProcessor()
    {
        creditCardPayment = new CreditCardPayment();
        payPalPayment = new PayPalPayment();
    }

    public void ProcessPayment(string paymentMethod)
    {
        if (paymentMethod == "CreditCard")
        {
            creditCardPayment.Pay();
        }
        else if (paymentMethod == "PayPal")
        {
            payPalPayment.Pay();
        }
    }
}

public class CreditCardPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment processed with Credit Card.");
    }
}

public class PayPalPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment processed with PayPal.");
    }
}
*/

//**********************************************************


// پرداخت با کارت اعتباری
IPaymentMethod creditCardPayment = new CreditCardPayment();
PaymentProcessor processor1 = new PaymentProcessor(creditCardPayment);
processor1.ProcessPayment();

// پرداخت با پی‌پال
IPaymentMethod payPalPayment = new PayPalPayment();
PaymentProcessor processor2 = new PaymentProcessor(payPalPayment);
processor2.ProcessPayment();

public interface IPaymentMethod
{
    void Pay();
}

public class CreditCardPayment : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Payment processed with Credit Card.");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Payment processed with PayPal.");
    }
}

public class PaymentProcessor
{
    private IPaymentMethod paymentMethod;

    // این کلاس از خارج یک IPaymentMethod را دریافت می‌کند
    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        this.paymentMethod = paymentMethod;
    }

    public void ProcessPayment()
    {
        paymentMethod.Pay();
    }
}
