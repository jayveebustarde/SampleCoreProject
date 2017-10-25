using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class OrderPaymentDTO : BaseDTO
    {
        public int OrderId { get; set; }
        public int PaymentId { get; set; }
        public OrderDTO Order { get; set; }
        public PaymentDTO Payment { get; set; }
    }
}
