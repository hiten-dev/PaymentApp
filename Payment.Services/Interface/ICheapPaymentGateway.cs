using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Services.Interface
{
    public interface ICheapPaymentGateway
    {
        public void ProcessCheapPayment(Data.Entities.Payment payment);
    }
}
