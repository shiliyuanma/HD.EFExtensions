using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2SpecialSymbolMap : EntityTypeConfiguration<MV2SpecialSymbol>
    {
        public MV2SpecialSymbolMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Symbol)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_SpecialSymbol");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BrokerId).HasColumnName("BrokerId");
            this.Property(t => t.Symbol).HasColumnName("Symbol");
            this.Property(t => t.ContractNum).HasColumnName("ContractNum");
            this.Property(t => t.Remark).HasColumnName("Remark");

        }
    }
}


