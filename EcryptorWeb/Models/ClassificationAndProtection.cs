using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class ClassificationAndProtection
    {
        public ClassificationAndProtection()
        {
            AipTemplateAllowedIdentities = new HashSet<AipTemplateAllowedIdentities>();
            AipTemplateScopedIdentities = new HashSet<AipTemplateScopedIdentities>();
            FileAipStatusMainLabelR = new HashSet<FileAipStatus>();
            FileAipStatusRmstemplateR = new HashSet<FileAipStatus>();
            FileAipStatusSubLabelR = new HashSet<FileAipStatus>();
        }

        public int ClassificationAndProtectionRid { get; set; }
        public Guid SourceKey { get; set; }
        public byte WorkloadRid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public bool IsDefault { get; set; }
        public bool Protection { get; set; }
        public bool Classification { get; set; }
        public Guid? LabelingSiteId { get; set; }

        public ICollection<AipTemplateAllowedIdentities> AipTemplateAllowedIdentities { get; set; }
        public ICollection<AipTemplateScopedIdentities> AipTemplateScopedIdentities { get; set; }
        public ICollection<FileAipStatus> FileAipStatusMainLabelR { get; set; }
        public ICollection<FileAipStatus> FileAipStatusRmstemplateR { get; set; }
        public ICollection<FileAipStatus> FileAipStatusSubLabelR { get; set; }
    }
}
