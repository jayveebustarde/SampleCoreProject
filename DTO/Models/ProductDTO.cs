using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class ProductDTO : BaseDTO
    {
        public string Name { get; set; }

        public int BrandId { get; set; }

        public string Type { get; set; }

        public bool IsPhasedOut { get; set; }

        public decimal Price { get; set; }

        public BrandDTO Brand { get; set; }
    }
}
