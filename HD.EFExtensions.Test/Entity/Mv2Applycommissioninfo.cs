using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2ApplyCommissionInfo
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public decimal ApplyAmount { get; set; }
        public Nullable<decimal> ReviewAmount { get; set; }
        public Nullable<decimal> PayAmount { get; set; }
        public Nullable<decimal> RealPay { get; set; }
        public Nullable<decimal> BankFee { get; set; }
        public string RealPayCurrency { get; set; }
        public Nullable<double> ExchangeRate { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public string ReivewBy { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public string PayBy { get; set; }
        public string Remark { get; set; }
    }
}


