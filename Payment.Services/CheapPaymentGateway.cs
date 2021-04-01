using Payment.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Services
{
    public class CheapPaymentGateway : ICheapPaymentGateway
    {
        public void ProcessCheapPayment(Data.Entities.Payment payment)
        {
        }
    }
}
