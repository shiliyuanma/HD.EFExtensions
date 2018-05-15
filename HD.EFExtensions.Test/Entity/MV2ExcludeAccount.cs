using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2ExcludeAccount
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int BrokerId { get; set; }
        public string Remark { get; set; }
        public Nullable<int> AccountType { get; set; }
    }
}


