using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Product : BaseAuditEntity
    {
        public string Name { get; set; }

        public int BrandId { get; set; }

        public string Type { get; set; }

        public bool IsPhasedOut { get; set; }

        public decimal Price { get; set; }

        #region Navigational Properties

        public Brand Brand { get; set; }

        #endregion
    }
}
