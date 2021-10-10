using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class District : AuditableBaseEntity
    {
        public int    CityId { get; set; }
        public string Name   { get; set; }
        public string Code   { get; set; }
    }
}
