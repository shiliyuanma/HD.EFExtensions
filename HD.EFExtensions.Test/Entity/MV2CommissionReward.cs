using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2CommissionReward
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public int MemberId { get; set; }
        public Nullable<decimal> RewardMoney { get; set; }
        public Nullable<decimal> MonthCommission { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<decimal> RewardPercent { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Remark { get; set; }
    }
}


