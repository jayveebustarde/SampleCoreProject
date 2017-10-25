using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class OrderItemDTO : BaseDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public string OrderedBy { get; set; }
        public string Status { get; set; }
        public string StatusHistory { get; set; }
        public Nullable<DateTime> ClaimDate { get; set; }
        public decimal Price { get; set; }
        
        public ProductDTO Product { get; set; }
        public OrderDTO Order { get; set; }
    }
}
