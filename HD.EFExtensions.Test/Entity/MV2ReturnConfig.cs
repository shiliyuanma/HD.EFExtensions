using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2ReturnConfig
    {
        public System.Guid ReturnConfigId { get; set; }
        public string ReturnConfigName { get; set; }
        public int BrokerId { get; set; }
        public System.Guid TradeTypeConfigId { get; set; }
        public string FormulaReturn { get; set; }
        public decimal PerHandReturn { get; set; }
        public Nullable<decimal> FollowReturn { get; set; }
        public double FollowPercent { get; set; }
        public int ConfigTypes { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Remark { get; set; }
    }
}


