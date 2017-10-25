using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class BaseAuditEntity : IAuditEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
