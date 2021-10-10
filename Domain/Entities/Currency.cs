using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Currency : AuditableBaseEntity
    {
        public int    CountryId { get; set; }
        public string Code      { get; set; }
        public string Unicode   { get; set; }
        public string HexCode   { get; set; }
        public string HtmlCode  { get; set; }
        public string CssCode   { get; set; }
    }
}
