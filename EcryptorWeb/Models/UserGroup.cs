using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            AipTemplateAllowedIdentities = new HashSet<AipTemplateAllowedIdentities>();
            AipTemplateScopedIdentities = new HashSet<AipTemplateScopedIdentities>();
            UserGroupMember = new HashSet<UserGroupMember>();
        }

        public long UserGroupRid { get; set; }
        public string UserGroupName { get; set; }
        public long UserGroupNameHash { get; set; }
        public string UserGroupDescription { get; set; }
        public string UserGroupType { get; set; }
        public string UserGroupEmail { get; set; }
        public Guid AadGroupObjectId { get; set; }
        public bool? IsSystem { get; set; }
        public DateTime? LastDirSyncTime { get; set; }
        public int GroupOwnerRid { get; set; }
        public short TenantRid { get; set; }
        public byte WorkloadRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public bool EcryptorAccess { get; set; }

        public User GroupOwnerR { get; set; }
        public ICollection<AipTemplateAllowedIdentities> AipTemplateAllowedIdentities { get; set; }
        public ICollection<AipTemplateScopedIdentities> AipTemplateScopedIdentities { get; set; }
        public ICollection<UserGroupMember> UserGroupMember { get; set; }
    }
}
