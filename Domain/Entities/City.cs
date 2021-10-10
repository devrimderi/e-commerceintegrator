using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class City : AuditableBaseEntity
    {
        public int    CountryId { get; set; }
        public string Name      { get; set; }
        public string Code      { get; set; }
    }
}
