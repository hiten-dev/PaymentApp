using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Payment.Data.Entities
{
    [Table("tblPayment")]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayementId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        [MaxLength(3)]
        public string SecurityCode { get; set; }
        [Range(1,int.MaxValue)]
        public decimal Amount { get; set; }
    }
}
