using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Contact : AuditableBaseEntity
    {
        public int    TypeId       { get; set; }
        public int    CompanyId    { get; set; }
        public string Name         { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber  { get; set; }
    }
}
