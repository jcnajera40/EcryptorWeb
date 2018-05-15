using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class Country
    {
        public Country()
        {
            User = new HashSet<User>();
        }

        public byte CountryRid { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public byte Workload { get; set; }
        public byte Tenant { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public byte TenantRid { get; set; }
        public byte WorkloadRid { get; set; }

        public ICollection<User> User { get; set; }
    }
}
