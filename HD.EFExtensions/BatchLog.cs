using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD.EFExtensions
{
    public class BatchLog
    {
        public static Action<string, DbParameterCollection> UpdateLog { get; set; }

        public static Action<string, DbParameterCollection> DeleteLog { get; set; }

    }
}
