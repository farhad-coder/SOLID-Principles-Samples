/*
// استفاده از کلاس‌های مختلف
BankAccount myAccount = new BankAccount();
Test.TestWithdraw(myAccount);  // حساب عادی، بدون محدودیت

BankAccount mySavings = new SavingsAccount();
Test.TestWithdraw(mySavings);  // حساب پس‌انداز، که محدودیت دارد


public class BankAccount
{
    public double Balance { get; set; }

    // واریز وجه به حساب
    public void Deposit(double amount)
    {
        Balance += amount;
    }

    // برداشت وجه از حساب
    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
}

public class SavingsAccount : BankAccount
{
    private bool _hasWithdrawn;

    // override کردن متد برداشت
    public new void Withdraw(double amount)
    {
        if (_hasWithdrawn)
        {
            Console.WriteLine("You can only withdraw once in a month from a savings account.");
        }
        else
        {
            base.Withdraw(amount);
            _hasWithdrawn = true;
        }
    }
}

public class Test
{
    public static void TestWithdraw(BankAccount account)
    {
        account.Deposit(1000);
        account.Withdraw(200);  // به نظر می‌رسد این متد باید به راحتی برداشت کند
        Console.WriteLine($"Balance: {account.Balance}");
    }
}
*/

//************************************************************

// استفاده از کلاس‌های مختلف
BankAccount myAccount = new BankAccount();
myAccount.Deposit(1000);  // واریز به حساب
Test.TestWithdraw(myAccount);   // حساب عادی، بدون محدودیت

IWithdrawable mySavings = new SavingsAccount();
((BankAccount)mySavings).Deposit(1000); // واریز به حساب پس‌انداز
Test.TestWithdraw(mySavings); // حساب پس‌انداز، که محدودیت دارد

public interface IWithdrawable
{
    void Withdraw(double amount);
}

public class BankAccount : IWithdrawable
{
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
}

public class SavingsAccount : BankAccount
{
    private bool _hasWithdrawn;

    // فقط برای حساب‌های پس‌انداز
    public override void Withdraw(double amount)
    {
        if (_hasWithdrawn)
        {
            Console.WriteLine("You can only withdraw once in a month from a savings account.");
        }
        else
        {
            base.Withdraw(amount);
            _hasWithdrawn = true;
        }
    }
}

public class Test
{
    public static void TestWithdraw(IWithdrawable account)
    {
        // فرض بر این است که واریز قبلاً انجام شده است
        account.Withdraw(200);  // با هر حسابی درست کار می‌کند
                                // چون IWithdrawable فقط Withdraw را شامل می‌شود، بنابراین فقط متد Withdraw قابل دسترسی است
        Console.WriteLine($"Balance: {((BankAccount)account).Balance}");
    }


}


