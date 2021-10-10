using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Country : AuditableBaseEntity
    {
        public string Name         { get; set; }
        public string Alpha2Code   { get; set; }
        public string Alpha3Code   { get; set; }
        public string PhoneCode    { get; set; }
    }
}
