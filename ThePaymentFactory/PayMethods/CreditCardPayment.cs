using System;

namespace ThePaymentFactory;
{
public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Succesfully paid ${amount} to merchant using Credit Card.");
    }
}
}
    