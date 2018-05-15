using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Member.Entity
{
    public  class UUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public Nullable<byte> PasswordFormat { get; set; }
        public string AccountEmail { get; set; }
        public Nullable<bool> IsEmailVerified { get; set; }
        public string AccountMobile { get; set; }
        public Nullable<bool> IsMobileVerified { get; set; }
        public string NickName { get; set; }
        public Nullable<byte> Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<bool> IsSystemAvata { get; set; }
        public string SystemAvataId { get; set; }
        public string FileObjectId { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public string LastLoginIP { get; set; }
        public Nullable<int> AccountRole { get; set; }
        public string RealName { get; set; }
        public string Nation { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Address { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string BankAddress { get; set; }
        public Nullable<byte> BankCardType { get; set; }
        public Nullable<byte> IDType { get; set; }
        public string IDNO { get; set; }
        public string Introduction { get; set; }
        public string StrategyDescription { get; set; }
        public Nullable<byte> Integrity { get; set; }
        public Nullable<int> ExperiencePoints { get; set; }
        public Nullable<int> FollowedCount { get; set; }
        public Nullable<int> FollowerCount { get; set; }
        public Nullable<byte> AccountStatus { get; set; }
        public Nullable<byte> UserType { get; set; }
        public Nullable<byte> CreateType { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string Remark { get; set; }
        public Nullable<int> OldId { get; set; }
        public string Certifications { get; set; }
        public Nullable<int> BloodGroup { get; set; }
        public Nullable<int> isCertification { get; set; }
        public Nullable<byte> RegPlatform { get; set; }
        public Nullable<int> LastSerialID { get; set; }
        public Nullable<bool> EnableMemberApply { get; set; }
        public Nullable<int> MemberState { get; set; }
        public Nullable<byte> MemberSource { get; set; }
        public string MemberDomain { get; set; }
        public string TradeExperience { get; set; }
        public string RiskPropensity { get; set; }
        public string TradeVariety { get; set; }
        public Nullable<int> CertLayout { get; set; }
    }
}
