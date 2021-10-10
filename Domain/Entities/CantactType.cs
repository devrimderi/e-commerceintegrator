using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class CantactType : AuditableBaseEntity
    {
        public int    CompanyId { get; set; }
        public string Name      { get; set; }
    }
}
