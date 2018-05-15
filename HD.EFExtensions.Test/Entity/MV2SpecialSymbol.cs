using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2SpecialSymbol
    {
        public int Id { get; set; }
        public int BrokerId { get; set; }
        public string Symbol { get; set; }
        public int ContractNum { get; set; }
        public string Remark { get; set; }
    }
}


