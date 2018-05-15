using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class City
    {
        public City()
        {
            User = new HashSet<User>();
        }

        public int CityRid { get; set; }
        public string CityName { get; set; }
        public int CountryRegionRid { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public byte WorkloadRid { get; set; }
        public byte TenantRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }

        public ICollection<User> User { get; set; }
    }
}
