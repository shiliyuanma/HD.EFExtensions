using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2MemberCommissionSummary
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Nullable<decimal> MemberAmount { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<decimal> Applied { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}


