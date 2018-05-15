using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2MemberDepartment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Nullable<int> SysUserId { get; set; }
        public int MemberType { get; set; }
        public Nullable<int> MemberState { get; set; }
        public string SubDomain { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public Nullable<System.DateTime> EnableDate { get; set; }
        public Nullable<int> UnPassReasons { get; set; }
    }
}


