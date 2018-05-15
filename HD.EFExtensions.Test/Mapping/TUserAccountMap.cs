using FM.Member.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Member.DAO.Mapping
{
    public class TUserAccountMap : EntityTypeConfiguration<TUserAccount>
    {
        public TUserAccountMap()
        {
            this.ToTable("T_UserAccount");
        }
    }
}
