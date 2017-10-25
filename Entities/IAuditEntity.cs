﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IAuditEntity : IEntity
    {
        DateTime CreatedDate { get; set; }
        Nullable<DateTime> LastUpdatedDate { get; set; }
    }
}
