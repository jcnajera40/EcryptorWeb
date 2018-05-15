using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class FileLocation
    {
        public FileLocation()
        {
            File = new HashSet<File>();
            FileAipStatus = new HashSet<FileAipStatus>();
        }

        public int FileLocationRid { get; set; }
        public byte WorkloadRid { get; set; }
        public string FileLocation1 { get; set; }
        public long FileLocationHash { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public int DeviceRid { get; set; }
        public short TenantRid { get; set; }

        public ICollection<File> File { get; set; }
        public ICollection<FileAipStatus> FileAipStatus { get; set; }
    }
}
