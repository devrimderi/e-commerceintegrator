using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Order : AuditableBaseEntity
    {
        public string OrderNumber { get; set; }
        public string IncomingOrderNumber { get; set; }
    }
}
