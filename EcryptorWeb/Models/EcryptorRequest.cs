using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class EcryptorRequest
    {
        public Guid EcryptorRequestRowid { get; set; }
        public int UserRequestorRid { get; set; }
        public string ResquestStatus { get; set; }
        public long FileRid { get; set; }
        public Guid RequestSession { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestorNotes { get; set; }
        public bool? RequestIsActive { get; set; }
        public short TenantRid { get; set; }
        public byte WorkloadRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }

        public File FileR { get; set; }
        public User UserRequestorR { get; set; }
    }
}
