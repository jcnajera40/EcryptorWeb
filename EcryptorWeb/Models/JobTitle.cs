using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            User = new HashSet<User>();
        }

        public short JobTitleRid { get; set; }
        public string JobTitle1 { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public byte WorkloadRid { get; set; }
        public byte TenantRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public long JobTitleHash { get; set; }
        public string JobTitleDescription { get; set; }

        public ICollection<User> User { get; set; }
    }
}
