using System;

namespace ThePaymentFactory;
{
public class PayPalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Succesfully paid ${amount} to merchant using PayPal.");
    }
}
}

