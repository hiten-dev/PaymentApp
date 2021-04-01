using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Services.Interface
{
    public interface IExpensivePaymentGateway
    {
        public void ProcessExpensivePayment(Data.Entities.Payment payment);
    }
}
