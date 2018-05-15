using FM.Member.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Member.DAO.Mapping
{
    public class UUserMap : EntityTypeConfiguration<UUser>
    {
        public UUserMap()
        {
            this.ToTable("U_User");
        }
    }
}
