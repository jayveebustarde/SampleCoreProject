using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class BrandDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}
