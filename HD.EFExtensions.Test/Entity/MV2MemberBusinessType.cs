using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2MemberBusinessType
    {
        public int Id { get; set; }
        public string BusinessTypeName { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Remark { get; set; }
    }
}


