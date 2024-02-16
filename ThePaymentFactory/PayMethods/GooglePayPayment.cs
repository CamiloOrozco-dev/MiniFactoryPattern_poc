using System;
using ThePaymentFactory.Interface

namespace ThePaymentFactory; 

public class GooglePayPayment : IPayment
{
    public void Pay ( double amount)
    {
        Console.WriteLine($"Succesfully paid ${amount} to merchant using GooglePay.");
    }
}
}
