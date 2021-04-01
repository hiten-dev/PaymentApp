using Payment.Models;
using Payment.Repository.interfaces;
using Payment.Services;
using Payment.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        ICheapPaymentGateway _cheapPaymentGateway;
        IExpensivePaymentGateway _expensivePaymentGateway;
        public PaymentRepository(ICheapPaymentGateway cheapPaymentGateway, IExpensivePaymentGateway expensivePaymentGateway)
        {
            _cheapPaymentGateway = cheapPaymentGateway;
            _expensivePaymentGateway = expensivePaymentGateway;
        }
        public void ProcessPayment(PayementModel payment)
        {
            Data.Entities.Payment pymt = ValidatePayment(payment);
            if (payment.Amount <= 20)
            {
                _cheapPaymentGateway.ProcessCheapPayment(pymt);
            }
            else if(payment.Amount >= 21 && payment.Amount <= 500)
            {
                try
                {
                    _expensivePaymentGateway.ProcessExpensivePayment(pymt);
                }
                catch(Exception e)
                {
                    _cheapPaymentGateway.ProcessCheapPayment(pymt);
                }
            }
            else
            {
                int trials = 3;
                while (trials > 0)
                {
                    try
                    {
                        trials--;
                        new PremiumPaymentService().ProcessPremiumPayment(pymt);
                    }
                    catch(Exception e)
                    {

                    }
                }
            }
        }
        public Data.Entities.Payment ValidatePayment(PayementModel payment)
        {
            Data.Entities.Payment pymt = new Data.Entities.Payment()
            {
                CreditCardNumber = payment.CreditCardNumber,
                CardHolder = payment.CardHolder,
                ExpirationDate = payment.ExpirationDate,
                SecurityCode = payment.SecurityCode,
                Amount = payment.Amount
            };
            return pymt;
        }
    }
}
