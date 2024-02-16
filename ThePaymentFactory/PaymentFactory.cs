using System;
namespace ThePaymentFactory

public class PaymentFactory 
{
	public static IPayment Create ( PaymentMethod paymentMethod)
	{
		switch (paymentMethod)
		{

			case PaymentMethod.CreditCard:

				return new CreditCardpayment();

			case paymentMethod.Paypal:

				return new PayPalPayment();

			case PaymentMethod.Google:

				return new GooglePayPayment();

			default:
				throw new NotSupportedException(
					$"{paymentMethod} is not currently supported as a payment method.");

		}
	}
}
