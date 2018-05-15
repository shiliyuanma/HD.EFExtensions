using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2ReturnGroup
    {
        public System.Guid ReturnGroupId { get; set; }
        public string ReturnGroupName { get; set; }
        public int MemberBusinessTypeId { get; set; }
        public Nullable<int> OrderByNumber { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Remark { get; set; }
    }
}


