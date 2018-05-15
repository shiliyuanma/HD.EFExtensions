using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2MemberRelationShip
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int ParentId { get; set; }
        public string ParentIds { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Remark { get; set; }
        public string ParentLevelCode { get; set; }
    }
}


