using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class UserGroupMember
    {
        public long UserGroupMemberRid { get; set; }
        public long UserGroupRid { get; set; }
        public int UserRid { get; set; }
        public short TenantRid { get; set; }
        public byte WorkloadRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }

        public UserGroup UserGroupR { get; set; }
        public User UserR { get; set; }
    }
}
