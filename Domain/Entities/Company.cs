using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Company : AuditableBaseEntity
    {
        public string Name   { get; set; }
        public int    TypeId { get; set; }
    }
}
