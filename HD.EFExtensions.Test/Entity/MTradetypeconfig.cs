using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MTradeTypeConfig
    {
        public System.Guid TradeTypeConfigId { get; set; }
        public string TradeTypeConfigName { get; set; }
        public int TradeSymbolType { get; set; }
        public int BrokerId { get; set; }
        public string SymbolName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}


