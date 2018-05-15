using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class FileAipStatus
    {
        public long FileAipStatusRid { get; set; }
        public long FileRid { get; set; }
        public int FileLocationRid { get; set; }
        public DateTime StatusChangeDate { get; set; }
        public bool IsLabeled { get; set; }
        public int MainLabelRid { get; set; }
        public int SubLabelRid { get; set; }
        public int FileOwnerRid { get; set; }
        public string LabelingMethod { get; set; }
        public DateTime? LabelDate { get; set; }
        public bool IsRmsprotected { get; set; }
        public int RmstemplateRid { get; set; }
        public short TenantRid { get; set; }
        public byte WorkloadRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }

        public FileLocation FileLocationR { get; set; }
        public User FileOwnerR { get; set; }
        public File FileR { get; set; }
        public ClassificationAndProtection MainLabelR { get; set; }
        public ClassificationAndProtection RmstemplateR { get; set; }
        public ClassificationAndProtection SubLabelR { get; set; }
    }
}
