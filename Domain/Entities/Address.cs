using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Address : AuditableBaseEntity
    {
        public string Name        { get; set; }
        public int    TypeId      { get; set; }
        public int    CompanyId   { get; set; }
        public string AddressLine { get; set; }
        public string Phone1      { get; set; }
        public string Phone2      { get; set; }
        public string PostalCode  { get; set; }
        public int    CityId      { get; set; }
        public int    DistrictId  { get; set; }
        public int    CountryId   { get; set; }
    }
}
