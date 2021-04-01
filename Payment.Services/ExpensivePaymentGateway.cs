using Payment.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Services
{
    public class ExpensivePaymentGateway : IExpensivePaymentGateway
    {
        public void ProcessExpensivePayment(Data.Entities.Payment payment)
        {

        }
    }
}
