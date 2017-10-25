using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class PaymentDTO : BaseDTO
    {
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
        
        public ICollection<OrderPaymentDTO> OrdersPaid { get; set; }

    }
}
