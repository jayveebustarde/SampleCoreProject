using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class OrderDTO : BaseDTO
    {
        public DateTime TransactionDate { get; set; }

        public decimal GrossTotal { get; set; }

        public decimal DiscountedTotal { get; set; }

        public bool IsFullyPaid { get; set; }

        public List<OrderPaymentDTO> Payments { get; set; }
    }
}
