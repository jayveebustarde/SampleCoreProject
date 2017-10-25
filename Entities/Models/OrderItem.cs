using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class OrderItem : BaseAuditEntity
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public int Quantity { get; set; }

        public string OrderedBy { get; set; }

        public string Status { get; set; }

        public string StatusHistory { get; set; }

        public DateTime ClaimDate { get; set; }

        public decimal Price { get; set; }

        #region Navigational Properties

        public Product Product { get; set; }

        public Order Order { get; set; }
        #endregion

    }
}
