using System;
using System.Collections.Generic;

interface IPayment
{
    bool ProcessPayment(decimal amount);
    string GetPaymentType();
}

interface ILoggable
{
    void Log();
}

class CreditCard : IPayment, ILoggable
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} using Credit Card");
        return amount > 0;
    }

    public string GetPaymentType()
    {
        return "Credit Card";
    }

    public void Log()
    {
        Console.WriteLine("Credit Card payment logged");
    }
}

class PayPal : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} using PayPal");
        return amount > 0;
    }

    public string GetPaymentType()
    {
        return "PayPal";
    }
}

class BankTransfer : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {amount} using Bank Transfer");
        return amount > 0;
    }

    public string GetPaymentType()
    {
        return "Bank Transfer";
    }
}

class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0)
                _balance = value;
            else
                Console.WriteLine("Invalid balance");
        }
    }

    public void Deposit(decimal amount, IPayment payment)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount");
            return;
        }

        if (payment.ProcessPayment(amount))
        {
            Balance += amount;
            Console.WriteLine($"Deposit successful using {payment.GetPaymentType()}");
            Console.WriteLine($"Current Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Payment failed");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        List<IPayment> payments = new List<IPayment>
        {
            new CreditCard(),
            new PayPal(),
            new BankTransfer()
        };

        decimal amount = 1000;

        foreach (IPayment payment in payments)
        {
            account.Deposit(amount, payment);
            Console.WriteLine();
        }

        CreditCard creditCard = new CreditCard();
        creditCard.Log();
    }
}