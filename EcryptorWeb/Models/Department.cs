using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class Department
    {
        public Department()
        {
            User = new HashSet<User>();
        }

        public short DepartmentRid { get; set; }
        public string DepartmentName { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public byte WorkloadRid { get; set; }
        public byte TenantRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public string DepartmentDescription { get; set; }
        public long DepartmentNameHash { get; set; }
        public short ParentDepartmentRid { get; set; }

        public ICollection<User> User { get; set; }
    }
}
