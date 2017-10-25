using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        #region Navigational Properties

        public ICollection<OrderPayment> OrdersPaid { get; set; }
        
        #endregion
    }
}
