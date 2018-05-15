using System;
using System.Collections.Generic;

namespace EcryptorWeb.Models
{
    public partial class User
    {
        public User()
        {
            AipTemplateAllowedIdentities = new HashSet<AipTemplateAllowedIdentities>();
            AipTemplateScopedIdentities = new HashSet<AipTemplateScopedIdentities>();
            EcryptorRequest = new HashSet<EcryptorRequest>();
            File = new HashSet<File>();
            FileAipStatus = new HashSet<FileAipStatus>();
            InverseManagerUserR = new HashSet<User>();
            InverseReports2UserR = new HashSet<User>();
            UserGroup = new HashSet<UserGroup>();
            UserGroupMember = new HashSet<UserGroupMember>();
        }

        public int UserRid { get; set; }
        public short TenantRid { get; set; }
        public Guid AadUserId { get; set; }
        public string UserPrincipalName { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserType { get; set; }
        public string UserUsageLocation { get; set; }
        public string UserPreferredLanguage { get; set; }
        public string UserPreferredDataLocation { get; set; }
        public bool AccountEnabled { get; set; }
        public DateTime? AccountDeletedDate { get; set; }
        public string OnPremisesDomain { get; set; }
        public string OnPremisesUserPrincipalName { get; set; }
        public bool OnPremisesSyncEnabled { get; set; }
        public string OnPremisesSamAccountName { get; set; }
        public DateTime? OnPremisesLastSyncDate { get; set; }
        public int? StrongAuthentictionRequirementId { get; set; }
        public bool MfaRequired { get; set; }
        public DateTime? MfaNotBeforeDate { get; set; }
        public string MfaState { get; set; }
        public string MfaRelayingParty { get; set; }
        public byte MfaMethodRid { get; set; }
        public short? CompanyRid { get; set; }
        public short? DepartmentRid { get; set; }
        public short? JobTitleRid { get; set; }
        public int? ManagerUserRid { get; set; }
        public int? Reports2UserRid { get; set; }
        public int? StreetAddressRid { get; set; }
        public byte? CountryRid { get; set; }
        public int? CountryRegionRid { get; set; }
        public int? CityRid { get; set; }
        public byte[] UserPhoto { get; set; }
        public string UserPhotoImageFileName { get; set; }
        public Guid SourceLoadSession { get; set; }
        public DateTime SourceLoadDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid LastChangeSession { get; set; }
        public byte[] RowVersion { get; set; }
        public byte WorkloadRid { get; set; }
        public Guid EvisordwCorrelationId { get; set; }
        public string AccountDescription { get; set; }
        public long UserPrincipalNameHash { get; set; }

        public City CityR { get; set; }
        public Country CountryR { get; set; }
        public Department DepartmentR { get; set; }
        public JobTitle JobTitleR { get; set; }
        public User ManagerUserR { get; set; }
        public User Reports2UserR { get; set; }
        public ICollection<AipTemplateAllowedIdentities> AipTemplateAllowedIdentities { get; set; }
        public ICollection<AipTemplateScopedIdentities> AipTemplateScopedIdentities { get; set; }
        public ICollection<EcryptorRequest> EcryptorRequest { get; set; }
        public ICollection<File> File { get; set; }
        public ICollection<FileAipStatus> FileAipStatus { get; set; }
        public ICollection<User> InverseManagerUserR { get; set; }
        public ICollection<User> InverseReports2UserR { get; set; }
        public ICollection<UserGroup> UserGroup { get; set; }
        public ICollection<UserGroupMember> UserGroupMember { get; set; }
    }
}
