using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MTradeTypeConfigMap : EntityTypeConfiguration<MTradeTypeConfig>
    {
        public MTradeTypeConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.TradeTypeConfigId);

            // Properties
            this.Property(t => t.TradeTypeConfigName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SymbolName)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("M_TradeTypeConfig");
            this.Property(t => t.TradeTypeConfigId).HasColumnName("TradeTypeConfigId");
            this.Property(t => t.TradeTypeConfigName).HasColumnName("TradeTypeConfigName");
            this.Property(t => t.TradeSymbolType).HasColumnName("TradeSymbolType");
            this.Property(t => t.BrokerId).HasColumnName("BrokerId");
            this.Property(t => t.SymbolName).HasColumnName("SymbolName");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");

        }
    }
}


