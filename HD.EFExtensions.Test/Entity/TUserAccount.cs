using System;
using System.Collections.Generic;
namespace FM.Member.Entity
{
    public partial class TUserAccount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MT4Account { get; set; }
        public Nullable<int> BrokerId { get; set; }
        public Nullable<int> AccountType { get; set; }
        public Nullable<int> MoneyType { get; set; }
        public Nullable<int> AccountStatus { get; set; }
        public string Remark { get; set; }
        public string MT4Password { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> FollowEnable { get; set; }
        public Nullable<int> FollowParameter { get; set; }
        public Nullable<int> IsPublish { get; set; }
        public Nullable<int> CreateType { get; set; }
        public string ManagerAccount { get; set; }
        public Nullable<int> FastTrade { get; set; }
        public string StrategyDescription { get; set; }
        public string Alias { get; set; }
        public Nullable<int> ProgressOfAccount { get; set; }
        public Nullable<byte> UserType { get; set; }
        public Nullable<byte> IsActive { get; set; }
        public Nullable<byte> AccountIndex { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<System.DateTime> LastActivityTime { get; set; }
        public Nullable<System.DateTime> PublishFrozenTime { get; set; }
    }
}
