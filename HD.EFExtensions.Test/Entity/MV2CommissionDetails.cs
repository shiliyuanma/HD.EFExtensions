using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2CommissionDetails
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public string Login { get; set; }
        public int BrokerId { get; set; }
        public int ParentId { get; set; }
        public string ParentIds { get; set; }
        public int TicketId { get; set; }
        public string Commission { get; set; }
        public Nullable<decimal> FollowReturn { get; set; }
        public Nullable<System.DateTime> OpenTime { get; set; }
        public Nullable<System.DateTime> CloseTime { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Remark { get; set; }
        public Nullable<double> Volume { get; set; }
        public string Symbol { get; set; }
        public Nullable<int> FollowerTargetUserId { get; set; }
        public string FollowerTargetNickName { get; set; }
        public Nullable<int> TradeSymbolType { get; set; }
        public Nullable<int> OrderType { get; set; }
        public Nullable<System.DateTime> BrokerCloseTime { get; set; }
        public string TraderID { get; set; }
        public Nullable<int> TraderBrokderID { get; set; }
        public Nullable<int> FollowerCmd { get; set; }
        public double StandardLots { get; set; }
        public string StandardSymbol { get; set; }
    }
}


