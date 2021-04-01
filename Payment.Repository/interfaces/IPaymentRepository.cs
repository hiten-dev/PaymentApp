using System;
using System.Collections.Generic;
using System.Text;
using Payment.Data.Entities;
using Payment.Models;

namespace Payment.Repository.interfaces
{
    public interface IPaymentRepository
    {
        void ProcessPayment(PayementModel payment);
    }
}
