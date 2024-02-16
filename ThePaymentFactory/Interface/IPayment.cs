using System;

namespace ThePaymentFactory.Interface;
{
     public interface IPayment
     {
        public IPayment()
       {
               void Pay(double amount);
        }
     }
}