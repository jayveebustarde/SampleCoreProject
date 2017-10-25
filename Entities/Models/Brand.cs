using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public decimal DiscountPercentage { get; set; }
    }
}
