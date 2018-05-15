using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class File
    {
        public File()
        {
            EcryptorRequest = new HashSet<EcryptorRequest>();
            FileAipStatus = new HashSet<FileAipStatus>();
        }

        public long FileRid { get; set; }
        public byte WorkloadRid { get; set; }
        public string FileName { get; set; }
        public long FileNameHash { get; set; }
        public Guid ContentId { get; set; }
        public int FileLocationRid { get; set; }
        public short FileTypeRid { get; set; }
        public int OwnerRid { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public short TenantRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public string InternalFileName { get; set; }
        public long InternalFileNameHash { get; set; }

        public FileLocation FileLocationR { get; set; }
        public FileType FileTypeR { get; set; }
        public User OwnerR { get; set; }
        public ICollection<EcryptorRequest> EcryptorRequest { get; set; }
        public ICollection<FileAipStatus> FileAipStatus { get; set; }
    }
}
