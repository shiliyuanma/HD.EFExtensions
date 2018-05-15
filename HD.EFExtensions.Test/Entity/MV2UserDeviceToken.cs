using System;
using System.Collections.Generic;

namespace FM.Member.Entity
{
    public partial class MV2UserDeviceToken
    {
        public int ID { get; set; }
        public Nullable<int> UserId { get; set; }
        public string DeviceToken { get; set; }
        public Nullable<short> PlatformType { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}


