using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2CommissionDaily
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public int UserId { get; set; }
        public int BrokerId { get; set; }
        public string MT4Account { get; set; }
        public string Commission { get; set; }
        public decimal FollowCommission { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
    }
}


