using System;

namespace DTO
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> LastUpdatedDate { get; set; }
    }
}
