using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class FileType
    {
        public FileType()
        {
            File = new HashSet<File>();
        }

        public short FileTypeRid { get; set; }
        public string FileExtension { get; set; }
        public string FileTypeName { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public byte TenantRid { get; set; }
        public byte WorkloadRid { get; set; }

        public ICollection<File> File { get; set; }
    }
}
