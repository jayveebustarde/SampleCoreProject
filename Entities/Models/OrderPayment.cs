using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class OrderPayment : BaseEntity
    {
        public int OrderId { get; set; }

        public int PaymentId { get; set; }

        #region Navigational Properties

        public Order Order { get; set; }

        public Payment Payment { get; set; }

        #endregion
    }
}
