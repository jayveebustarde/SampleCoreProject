using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Order : BaseAuditEntity
    {
        public DateTime TransactionDate { get; set; }

        public decimal GrossTotal { get; set; }

        public decimal DiscountedTotal { get; set; }

        public bool IsFullyPaid { get; set; }

        #region Navigational Properties

        public ICollection<OrderPayment> Payments { get; set; }

        #endregion
    }
}
