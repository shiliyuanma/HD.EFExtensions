using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2MemberDaily
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public int MemberId { get; set; }
        public int ParentId { get; set; }
        public int BrokerId { get; set; }
        public Nullable<int> NewUserCount { get; set; }
        public Nullable<int> ActiveUserCount { get; set; }
        public Nullable<int> Orders { get; set; }
        public Nullable<decimal> Point { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<decimal> Commission { get; set; }
        public Nullable<decimal> Swaps { get; set; }
        public Nullable<decimal> Profit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<int> WinOrders { get; set; }
        public Nullable<int> LoseOrders { get; set; }
        public Nullable<decimal> WinProfit { get; set; }
        public Nullable<decimal> LoseProfit { get; set; }
        public Nullable<decimal> WinPoint { get; set; }
        public Nullable<decimal> LosePoint { get; set; }
        public Nullable<decimal> MaxPoint { get; set; }
        public Nullable<decimal> MinPoint { get; set; }
        public Nullable<int> BuyOrders { get; set; }
        public Nullable<int> SellOrders { get; set; }
        public Nullable<int> WinAndBuyOrders { get; set; }
        public Nullable<int> WinAndSellOrders { get; set; }
        public Nullable<decimal> InMoney { get; set; }
        public Nullable<decimal> FollowVolume { get; set; }
        public Nullable<decimal> SlefVolume { get; set; }
        public Nullable<decimal> BuyVolume { get; set; }
        public Nullable<decimal> SellVolume { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> BalancePrev { get; set; }
        public Nullable<decimal> Equity { get; set; }
        public Nullable<decimal> FollowProfit { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public string ParentIds { get; set; }
        public Nullable<decimal> OutMoney { get; set; }
    }
}


