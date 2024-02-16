
using ThePaymentFactory;
// Change the Payment method to create diferents class to pay
IPayment payment = PaymentFactory.Create(PaymentMethod.CreditCard);
payment.Pay(1000.00);