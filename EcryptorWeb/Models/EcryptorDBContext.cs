using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EcryptorWeb.Models
{
    public partial class EcryptorDBContext : DbContext
    {
        //public virtual DbSet<AipTemplateAllowedIdentities> AipTemplateAllowedIdentities { get; set; }
        //public virtual DbSet<AipTemplateScopedIdentities> AipTemplateScopedIdentities { get; set; }
        //public virtual DbSet<City> City { get; set; }
        //public virtual DbSet<ClassificationAndProtection> ClassificationAndProtection { get; set; }
        //public virtual DbSet<Country> Country { get; set; }
        //public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EcryptorRequest> EcryptorRequest { get; set; }
        //public virtual DbSet<File> File { get; set; }
        //public virtual DbSet<FileAipStatus> FileAipStatus { get; set; }
        //public virtual DbSet<FileLocation> FileLocation { get; set; }
        //public virtual DbSet<FileType> FileType { get; set; }
        //public virtual DbSet<JobTitle> JobTitle { get; set; }
        //public virtual DbSet<User> User { get; set; }
        //public virtual DbSet<UserGroup> UserGroup { get; set; }
        //public virtual DbSet<UserGroupMember> UserGroupMember { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"server=evisordbsrv.database.windows.net;User ID=jcnajera@evisordbsrv;Password=Juan2017!;database=evisordw");
        //            }
        //        }

        public EcryptorDBContext(DbContextOptions<EcryptorDBContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AipTemplateAllowedIdentities>(entity =>
            //{
            //    entity.HasKey(e => e.AipTemplateAllowedIdentitiesRid)
            //        .ForSqlServerIsClustered(false);

            //    entity.ToTable("AIP Template Allowed Identities");

            //    entity.HasIndex(e => e.CreationDate)
            //        .HasName("IX_AIP_Template_Allowed_Identities_creation_DATE")
            //        .ForSqlServerIsClustered();

            //    entity.Property(e => e.AipTemplateAllowedIdentitiesRid).HasColumnName("AIP_Template_Allowed_Identities_RID");

            //    entity.Property(e => e.CreationDate)
            //        .HasColumnName("Creation Date")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.EvisordwCorrelationId).HasColumnName("evisordw_correlation_id");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession)
            //        .HasColumnName("lastChangeSession")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TemplateRid)
            //        .HasColumnName("Template_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserGroupRid)
            //        .HasColumnName("User_Group_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserRid)
            //        .HasColumnName("User_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserRights)
            //        .HasColumnName("User Rights")
            //        .IsUnicode(false)
            //        .HasDefaultValueSql("('CLEAR')");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.TemplateR)
            //        .WithMany(p => p.AipTemplateAllowedIdentities)
            //        .HasForeignKey(d => d.TemplateRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_AIP_Template_Allowed_Identities_2_classification_And_Protection");

            //    entity.HasOne(d => d.UserGroupR)
            //        .WithMany(p => p.AipTemplateAllowedIdentities)
            //        .HasForeignKey(d => d.UserGroupRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_AIP_Template_Allowed_Identities_2_User_Group");

            //    entity.HasOne(d => d.UserR)
            //        .WithMany(p => p.AipTemplateAllowedIdentities)
            //        .HasForeignKey(d => d.UserRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_AIP_Template_Allowed_Identities_2_User");
            //});

            //modelBuilder.Entity<AipTemplateScopedIdentities>(entity =>
            //{
            //    entity.HasKey(e => e.AipTemplateScopedIdentitiesRid)
            //        .ForSqlServerIsClustered(false);

            //    entity.ToTable("AIP Template Scoped Identities");

            //    entity.HasIndex(e => e.CreationDate)
            //        .HasName("IX_AIP_Template_Scoped_Identities_creation_DATE")
            //        .ForSqlServerIsClustered();

            //    entity.Property(e => e.AipTemplateScopedIdentitiesRid).HasColumnName("AIP_Template_Scoped_Identities_RID");

            //    entity.Property(e => e.CreationDate)
            //        .HasColumnName("Creation Date")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.EvisordwCorrelationId).HasColumnName("evisordw_correlation_id");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession)
            //        .HasColumnName("lastChangeSession")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TemplateRid)
            //        .HasColumnName("Template_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserGroupRid)
            //        .HasColumnName("User_Group_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserRid)
            //        .HasColumnName("User_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserRights)
            //        .HasColumnName("User Rights")
            //        .IsUnicode(false)
            //        .HasDefaultValueSql("('CLEAR')");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.TemplateR)
            //        .WithMany(p => p.AipTemplateScopedIdentities)
            //        .HasForeignKey(d => d.TemplateRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_AIP_Template_Scoped_Identities_2_classification_And_Protection");

            //    entity.HasOne(d => d.UserGroupR)
            //        .WithMany(p => p.AipTemplateScopedIdentities)
            //        .HasForeignKey(d => d.UserGroupRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_AIP_Template_Scoped_Identities_2_User_Group");

            //    entity.HasOne(d => d.UserR)
            //        .WithMany(p => p.AipTemplateScopedIdentities)
            //        .HasForeignKey(d => d.UserRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_AIP_Template_Scoped_Identities_2_User");
            //});

            //modelBuilder.Entity<City>(entity =>
            //{
            //    entity.HasKey(e => e.CityRid);

            //    entity.HasIndex(e => new { e.CityName, e.CountryRegionRid })
            //        .HasName("UN_City_City_Name_CountyRegion")
            //        .IsUnique();

            //    entity.Property(e => e.CityRid).HasColumnName("City_RID");

            //    entity.Property(e => e.CityName)
            //        .IsRequired()
            //        .HasColumnName("City Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CountryRegionRid)
            //        .HasColumnName("Country_Region_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("workload_RID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<ClassificationAndProtection>(entity =>
            //{
            //    entity.HasKey(e => e.ClassificationAndProtectionRid);

            //    entity.ToTable("Classification and Protection");

            //    entity.HasIndex(e => new { e.SourceKey, e.WorkloadRid })
            //        .HasName("UN_ClassificationAndProtection_SourceKey_Workload")
            //        .IsUnique();

            //    entity.Property(e => e.ClassificationAndProtectionRid).HasColumnName("Classification_And_Protection_RID");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.IsDefault).HasColumnName("isDefault");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceKey).HasColumnName("Source Key");

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.Type).HasColumnType("char(10)");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<Country>(entity =>
            //{
            //    entity.HasKey(e => e.CountryRid);

            //    entity.HasIndex(e => e.CountryName)
            //        .HasName("UN_Country_CountryName")
            //        .IsUnique();

            //    entity.Property(e => e.CountryRid)
            //        .HasColumnName("Country_RID")
            //        .ValueGeneratedOnAdd();

            //    entity.Property(e => e.CountryCode)
            //        .IsRequired()
            //        .HasColumnName("Country Code")
            //        .HasColumnType("char(3)")
            //        .HasDefaultValueSql("('')");

            //    entity.Property(e => e.CountryName)
            //        .IsRequired()
            //        .HasColumnName("Country Name")
            //        .HasMaxLength(255)
            //        .HasDefaultValueSql("('')");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.Tenant)
            //        .HasColumnName("tenant")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Workload)
            //        .HasColumnName("workload")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("workload_RID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<Department>(entity =>
            //{
            //    entity.HasKey(e => e.DepartmentRid);

            //    entity.Property(e => e.DepartmentRid).HasColumnName("Department_RID");

            //    entity.Property(e => e.DepartmentDescription).HasColumnName("Department description");

            //    entity.Property(e => e.DepartmentName)
            //        .HasColumnName("Department Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DepartmentNameHash)
            //        .HasColumnName("Department name HASH")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.ParentDepartmentRid)
            //        .HasColumnName("parent_department_rid")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("workload_RID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<EcryptorRequest>(entity =>
            //{
            //    entity.HasKey(e => e.EcryptorRequestRowid)
            //        .ForSqlServerIsClustered(false);

            //    entity.ToTable("Ecryptor Request");

            //    entity.Property(e => e.EcryptorRequestRowid)
            //        .HasColumnName("Ecryptor_Request_ROWID")
            //        .HasDefaultValueSql("(newsequentialid())");

            //    entity.Property(e => e.EvisordwCorrelationId).HasColumnName("evisordw_correlation_id");

            //    entity.Property(e => e.FileRid)
            //        .HasColumnName("File_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.RequestDate)
            //        .HasColumnName("Request Date")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.RequestIsActive)
            //        .HasColumnName("Request is Active")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.RequestSession).HasColumnName("Request Session");

            //    entity.Property(e => e.RequestorNotes).HasColumnName("Requestor Notes");

            //    entity.Property(e => e.ResquestStatus)
            //        .IsRequired()
            //        .HasColumnName("Resquest Status")
            //        .HasColumnType("char(20)")
            //        .HasDefaultValueSql("('Request')");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid).HasColumnName("tenant_RID");

            //    entity.Property(e => e.UserRequestorRid)
            //        .HasColumnName("User_Requestor_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.FileR)
            //        .WithMany(p => p.EcryptorRequest)
            //        .HasForeignKey(d => d.FileRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Ecryptor_Request_2_file");

            //    entity.HasOne(d => d.UserRequestorR)
            //        .WithMany(p => p.EcryptorRequest)
            //        .HasForeignKey(d => d.UserRequestorRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Ecryptor_Request_2_USER");
            //});

            //modelBuilder.Entity<File>(entity =>
            //{
            //    entity.HasKey(e => e.FileRid)
            //        .ForSqlServerIsClustered(false);

            //    entity.HasIndex(e => new { e.FileName, e.FileLocationRid })
            //        .HasName("IX_File_File_Path")
            //        .ForSqlServerIsClustered();

            //    entity.HasIndex(e => new { e.FileNameHash, e.FileLocationRid })
            //        .HasName("UN_File_Name_Path")
            //        .IsUnique();

            //    entity.Property(e => e.FileRid).HasColumnName("File_RID");

            //    entity.Property(e => e.ContentId).HasDefaultValueSql("(CONVERT([uniqueidentifier],'00000000-0000-0000-0000-000000000000'))");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.FileLocationRid)
            //        .HasColumnName("File_Location_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.FileName)
            //        .IsRequired()
            //        .HasColumnName("File Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FileNameHash).HasColumnName("File Name HASH");

            //    entity.Property(e => e.FileTypeRid)
            //        .HasColumnName("File_Type_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.InternalFileName)
            //        .HasColumnName("Internal File Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.InternalFileNameHash)
            //        .HasColumnName("Internal File Name HASH")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.OwnerRid)
            //        .HasColumnName("Owner_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.FileLocationR)
            //        .WithMany(p => p.File)
            //        .HasForeignKey(d => d.FileLocationRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_2_File_Location");

            //    entity.HasOne(d => d.FileTypeR)
            //        .WithMany(p => p.File)
            //        .HasForeignKey(d => d.FileTypeRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_2_File_Type");

            //    entity.HasOne(d => d.OwnerR)
            //        .WithMany(p => p.File)
            //        .HasForeignKey(d => d.OwnerRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_2_Owner_User");
            //});

            //modelBuilder.Entity<FileAipStatus>(entity =>
            //{
            //    entity.HasKey(e => e.FileAipStatusRid)
            //        .ForSqlServerIsClustered(false);

            //    entity.ToTable("File AIP Status");

            //    entity.HasIndex(e => e.StatusChangeDate)
            //        .HasName("IX_File_AIP_STATUS_CHANGE_DATE")
            //        .ForSqlServerIsClustered();

            //    entity.Property(e => e.FileAipStatusRid).HasColumnName("File_AIP_Status_RID");

            //    entity.Property(e => e.EvisordwCorrelationId).HasColumnName("evisordw_correlation_id");

            //    entity.Property(e => e.FileLocationRid)
            //        .HasColumnName("File_Location_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.FileOwnerRid)
            //        .HasColumnName("File_Owner_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.FileRid)
            //        .HasColumnName("File_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IsRmsprotected).HasColumnName("IsRMSProtected");

            //    entity.Property(e => e.LabelDate).HasColumnType("datetime");

            //    entity.Property(e => e.LabelingMethod)
            //        .IsRequired()
            //        .HasColumnType("char(20)")
            //        .HasDefaultValueSql("('Manual')");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession)
            //        .HasColumnName("lastChangeSession")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.MainLabelRid)
            //        .HasColumnName("MainLabel_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.RmstemplateRid)
            //        .HasColumnName("RMSTemplate_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.StatusChangeDate)
            //        .HasColumnName("Status Change Date")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.SubLabelRid)
            //        .HasColumnName("SubLabel_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.FileLocationR)
            //        .WithMany(p => p.FileAipStatus)
            //        .HasForeignKey(d => d.FileLocationRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_AIP_STATUS_2_File_Location");

            //    entity.HasOne(d => d.FileOwnerR)
            //        .WithMany(p => p.FileAipStatus)
            //        .HasForeignKey(d => d.FileOwnerRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_AIP_STATUS_2_File_Owner");

            //    entity.HasOne(d => d.FileR)
            //        .WithMany(p => p.FileAipStatus)
            //        .HasForeignKey(d => d.FileRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_AIP_STATUS_2_File");

            //    entity.HasOne(d => d.MainLabelR)
            //        .WithMany(p => p.FileAipStatusMainLabelR)
            //        .HasForeignKey(d => d.MainLabelRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_AIP_STATUS_2_MainLables");

            //    entity.HasOne(d => d.RmstemplateR)
            //        .WithMany(p => p.FileAipStatusRmstemplateR)
            //        .HasForeignKey(d => d.RmstemplateRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_AIP_STATUS_2_RMS_Templates");

            //    entity.HasOne(d => d.SubLabelR)
            //        .WithMany(p => p.FileAipStatusSubLabelR)
            //        .HasForeignKey(d => d.SubLabelRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_File_AIP_STATUS_2_SubLables");
            //});

            //modelBuilder.Entity<FileLocation>(entity =>
            //{
            //    entity.HasKey(e => e.FileLocationRid);

            //    entity.ToTable("File Location");

            //    entity.HasIndex(e => e.FileLocationHash)
            //        .HasName("UN_File_Location_HASH")
            //        .IsUnique();

            //    entity.Property(e => e.FileLocationRid).HasColumnName("File_Location_RID");

            //    entity.Property(e => e.DeviceRid)
            //        .HasColumnName("Device_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.FileLocation1)
            //        .IsRequired()
            //        .HasColumnName("File Location");

            //    entity.Property(e => e.FileLocationHash).HasColumnName("File Location HASH");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("Tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<FileType>(entity =>
            //{
            //    entity.HasKey(e => e.FileTypeRid);

            //    entity.ToTable("File Type");

            //    entity.HasIndex(e => e.FileExtension)
            //        .HasName("UN_File_Type_Extension")
            //        .IsUnique();

            //    entity.Property(e => e.FileTypeRid).HasColumnName("File_Type_RID");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.FileExtension)
            //        .IsRequired()
            //        .HasColumnName("File Extension")
            //        .HasColumnType("char(16)");

            //    entity.Property(e => e.FileTypeName)
            //        .HasColumnName("File Type Name")
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("workload_RID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<JobTitle>(entity =>
            //{
            //    entity.HasKey(e => e.JobTitleRid);

            //    entity.ToTable("Job Title");

            //    entity.HasIndex(e => e.JobTitleHash)
            //        .HasName("UN_JobTitle_Job_Title_HASH")
            //        .IsUnique();

            //    entity.Property(e => e.JobTitleRid).HasColumnName("Job_Title_RID");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.JobTitle1)
            //        .IsRequired()
            //        .HasColumnName("Job Title")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.JobTitleDescription).HasColumnName("Job title description");

            //    entity.Property(e => e.JobTitleHash)
            //        .HasColumnName("Job Title HASH")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("workload_RID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.HasKey(e => e.UserRid);

            //    entity.HasIndex(e => e.UserPrincipalName)
            //        .HasName("UN_User_UPN")
            //        .IsUnique();

            //    entity.HasIndex(e => e.UserPrincipalNameHash)
            //        .HasName("ix_User_upnhash")
            //        .IsUnique();

            //    entity.Property(e => e.UserRid).HasColumnName("User_RID");

            //    entity.Property(e => e.AadUserId).HasColumnName("AAD_UserId");

            //    entity.Property(e => e.AccountDeletedDate)
            //        .HasColumnName("Account Deleted Date")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.AccountDescription).HasColumnName("Account description");

            //    entity.Property(e => e.AccountEnabled).HasColumnName("Account Enabled");

            //    entity.Property(e => e.CityRid)
            //        .HasColumnName("City_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.CompanyRid)
            //        .HasColumnName("Company_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.CountryRegionRid)
            //        .HasColumnName("Country_Region_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.CountryRid)
            //        .HasColumnName("Country_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.DepartmentRid)
            //        .HasColumnName("Department_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.EvisordwCorrelationId)
            //        .HasColumnName("evisordw_correlation_id")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.JobTitleRid)
            //        .HasColumnName("Job_Title_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession).HasColumnName("lastChangeSession");

            //    entity.Property(e => e.ManagerUserRid)
            //        .HasColumnName("Manager_User_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.MfaMethodRid)
            //        .HasColumnName("Mfa_Method_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.MfaNotBeforeDate)
            //        .HasColumnName("MFA Not Before Date")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.MfaRelayingParty)
            //        .HasColumnName("MFA Relaying Party")
            //        .HasMaxLength(125)
            //        .IsUnicode(false);

            //    entity.Property(e => e.MfaRequired).HasColumnName("MFA Required");

            //    entity.Property(e => e.MfaState)
            //        .HasColumnName("MFA State")
            //        .HasColumnType("char(20)");

            //    entity.Property(e => e.OnPremisesDomain)
            //        .HasColumnName("On Premises Domain")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.OnPremisesLastSyncDate)
            //        .HasColumnName("On Premises Last Sync Date")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.OnPremisesSamAccountName)
            //        .HasColumnName("On Premises SamAccountName")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.OnPremisesSyncEnabled).HasColumnName("On Premises Sync Enabled");

            //    entity.Property(e => e.OnPremisesUserPrincipalName)
            //        .HasColumnName("On Premises  User Principal Name")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Reports2UserRid)
            //        .HasColumnName("Reports2_User_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.StreetAddressRid)
            //        .HasColumnName("Street_Address_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.StrongAuthentictionRequirementId).HasColumnName("StrongAuthentictionRequirementID");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("Tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserMail)
            //        .HasColumnName("User Mail")
            //        .HasMaxLength(225);

            //    entity.Property(e => e.UserName)
            //        .IsRequired()
            //        .HasColumnName("User Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.UserPhoto).HasColumnName("User Photo");

            //    entity.Property(e => e.UserPhotoImageFileName)
            //        .HasColumnName("User Photo Image File Name")
            //        .HasColumnType("char(40)")
            //        .HasDefaultValueSql("('GenericPhoto.JPG')");

            //    entity.Property(e => e.UserPreferredDataLocation)
            //        .HasColumnName("User Preferred Data Location")
            //        .HasColumnType("char(2)");

            //    entity.Property(e => e.UserPreferredLanguage)
            //        .HasColumnName("User Preferred Language")
            //        .HasColumnType("char(2)");

            //    entity.Property(e => e.UserPrincipalName)
            //        .IsRequired()
            //        .HasColumnName("User Principal Name")
            //        .HasColumnType("nchar(50)");

            //    entity.Property(e => e.UserPrincipalNameHash)
            //        .HasColumnName("User Principal Name HASH")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserType)
            //        .IsRequired()
            //        .HasColumnName("User Type")
            //        .HasColumnType("char(10)");

            //    entity.Property(e => e.UserUsageLocation)
            //        .HasColumnName("User Usage Location")
            //        .HasColumnType("char(2)");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.CityR)
            //        .WithMany(p => p.User)
            //        .HasForeignKey(d => d.CityRid)
            //        .HasConstraintName("FK_User_2_City");

            //    entity.HasOne(d => d.CountryR)
            //        .WithMany(p => p.User)
            //        .HasForeignKey(d => d.CountryRid)
            //        .HasConstraintName("FK_User_2_Country");

            //    entity.HasOne(d => d.DepartmentR)
            //        .WithMany(p => p.User)
            //        .HasForeignKey(d => d.DepartmentRid)
            //        .HasConstraintName("FK_User_2_Department");

            //    entity.HasOne(d => d.JobTitleR)
            //        .WithMany(p => p.User)
            //        .HasForeignKey(d => d.JobTitleRid)
            //        .HasConstraintName("FK_User_2_Job_Title");

            //    entity.HasOne(d => d.ManagerUserR)
            //        .WithMany(p => p.InverseManagerUserR)
            //        .HasForeignKey(d => d.ManagerUserRid)
            //        .HasConstraintName("FK_User_2_Manager");

            //    entity.HasOne(d => d.Reports2UserR)
            //        .WithMany(p => p.InverseReports2UserR)
            //        .HasForeignKey(d => d.Reports2UserRid)
            //        .HasConstraintName("FK_User_2_Reports2");
            //});

            //modelBuilder.Entity<UserGroup>(entity =>
            //{
            //    entity.HasKey(e => e.UserGroupRid);

            //    entity.ToTable("User Group");

            //    entity.HasIndex(e => e.UserGroupNameHash)
            //        .HasName("UN_USER_GROUP_NAME_HASH")
            //        .IsUnique();

            //    entity.Property(e => e.UserGroupRid).HasColumnName("User_Group_RID");

            //    entity.Property(e => e.AadGroupObjectId).HasColumnName("AAD_GROUP_OBJECT_ID");

            //    entity.Property(e => e.EcryptorAccess).HasColumnName("Ecryptor access");

            //    entity.Property(e => e.EvisordwCorrelationId).HasColumnName("evisordw_correlation_id");

            //    entity.Property(e => e.GroupOwnerRid)
            //        .HasColumnName("Group_Owner_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession)
            //        .HasColumnName("lastChangeSession")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.LastDirSyncTime).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserGroupDescription)
            //        .IsRequired()
            //        .HasColumnName("User Group Description");

            //    entity.Property(e => e.UserGroupEmail)
            //        .HasColumnName("User Group email")
            //        .HasMaxLength(255)
            //        .IsUnicode(false);

            //    entity.Property(e => e.UserGroupName)
            //        .IsRequired()
            //        .HasColumnName("User Group Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.UserGroupNameHash).HasColumnName("User Group Name HASH");

            //    entity.Property(e => e.UserGroupType)
            //        .IsRequired()
            //        .HasColumnName("User Group Type")
            //        .HasColumnType("char(30)")
            //        .HasDefaultValueSql("('Unknown')");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.GroupOwnerR)
            //        .WithMany(p => p.UserGroup)
            //        .HasForeignKey(d => d.GroupOwnerRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_USER_GROUP_2_User");
            //});

            //modelBuilder.Entity<UserGroupMember>(entity =>
            //{
            //    entity.HasKey(e => e.UserGroupMemberRid);

            //    entity.ToTable("User Group Member");

            //    entity.Property(e => e.UserGroupMemberRid).HasColumnName("User_Group_Member_RID");

            //    entity.Property(e => e.EvisordwCorrelationId).HasColumnName("evisordw_correlation_id");

            //    entity.Property(e => e.LastChangeDateTime)
            //        .HasColumnName("lastChangeDateTime")
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.LastChangeSession)
            //        .HasColumnName("lastChangeSession")
            //        .HasDefaultValueSql("(newid())");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .HasColumnName("rowVersion")
            //        .IsRowVersion();

            //    entity.Property(e => e.SourceLoadDate)
            //        .HasColumnName("sourceLoadDate")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.SourceLoadSession).HasColumnName("sourceLoadSession");

            //    entity.Property(e => e.TenantRid)
            //        .HasColumnName("tenant_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserGroupRid)
            //        .HasColumnName("User_Group_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserRid)
            //        .HasColumnName("User_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.WorkloadRid)
            //        .HasColumnName("Workload_RID")
            //        .HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.UserGroupR)
            //        .WithMany(p => p.UserGroupMember)
            //        .HasForeignKey(d => d.UserGroupRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_USER_GROUP_MEMBER_2_User_GROUP");

            //    entity.HasOne(d => d.UserR)
            //        .WithMany(p => p.UserGroupMember)
            //        .HasForeignKey(d => d.UserRid)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_USER_GROUP_Member_2_User");
            //});
        }
    }
}
