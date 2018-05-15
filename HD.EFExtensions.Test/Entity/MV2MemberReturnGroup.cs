using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2MemberReturnGroup
    {
        public int MemberId { get; set; }
        public System.Guid ReturnGroupId { get; set; }
        public int MemberBusinessTypeId { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Remark { get; set; }
    }
}


