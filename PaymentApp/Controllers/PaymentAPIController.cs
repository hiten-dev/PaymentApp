using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.Data;
using Payment.Models;
using Payment.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentAPIController : ControllerBase
    {
        IPaymentRepository _paymentRepository;
        ApplicationContext _applicationContext;
        public PaymentAPIController(IPaymentRepository paymentRepository, ApplicationContext context)
        {
            _paymentRepository = paymentRepository;
            _applicationContext = context;
        }
        /// <summary>
        /// Process a new payment
        /// </summary>
        /// <param name="value"></param>
        // POST api/ProcessPayment
        [HttpPost]
        public void ProcessPayment([FromBody] PayementModel value)
        {
            _paymentRepository.ProcessPayment(value);
        }
    }
}
