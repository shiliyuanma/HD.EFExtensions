using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2ReturnConfigMap : EntityTypeConfiguration<MV2ReturnConfig>
    {
        public MV2ReturnConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ReturnConfigId);

            // Properties
            this.Property(t => t.ReturnConfigName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FormulaReturn)
                .HasMaxLength(2000);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_ReturnConfig");
            this.Property(t => t.ReturnConfigId).HasColumnName("ReturnConfigId");
            this.Property(t => t.ReturnConfigName).HasColumnName("ReturnConfigName");
            this.Property(t => t.BrokerId).HasColumnName("BrokerId");
            this.Property(t => t.TradeTypeConfigId).HasColumnName("TradeTypeConfigId");
            this.Property(t => t.FormulaReturn).HasColumnName("FormulaReturn");
            this.Property(t => t.PerHandReturn).HasColumnName("PerHandReturn");
            this.Property(t => t.FollowReturn).HasColumnName("FollowReturn");
            this.Property(t => t.FollowPercent).HasColumnName("FollowPercent");
            this.Property(t => t.ConfigTypes).HasColumnName("ConfigTypes");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.Remark).HasColumnName("Remark");

        }
    }
}


