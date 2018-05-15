using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2ReturnGroupReturnConfigMap : EntityTypeConfiguration<MV2ReturnGroupReturnConfig>
    {
        public MV2ReturnGroupReturnConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("MV2_ReturnGroup_ReturnConfig");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ReturnGroupId).HasColumnName("ReturnGroupId");
            this.Property(t => t.ReturnConfigId).HasColumnName("ReturnConfigId");

        }
    }
}


