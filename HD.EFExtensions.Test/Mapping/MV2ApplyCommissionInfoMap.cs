using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2ApplyCommissionInfoMap : EntityTypeConfiguration<MV2ApplyCommissionInfo>
    {
        public MV2ApplyCommissionInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RealPayCurrency)
                .HasMaxLength(10);

            this.Property(t => t.ReivewBy)
                .HasMaxLength(50);

            this.Property(t => t.PayBy)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_ApplyCommissionInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.ApplyAmount).HasColumnName("ApplyAmount");
            this.Property(t => t.ReviewAmount).HasColumnName("ReviewAmount");
            this.Property(t => t.PayAmount).HasColumnName("PayAmount");
            this.Property(t => t.RealPay).HasColumnName("RealPay");
            this.Property(t => t.BankFee).HasColumnName("BankFee");
            this.Property(t => t.RealPayCurrency).HasColumnName("RealPayCurrency");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ApplyDate).HasColumnName("ApplyDate");
            this.Property(t => t.ReviewDate).HasColumnName("ReviewDate");
            this.Property(t => t.ReivewBy).HasColumnName("ReivewBy");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.PayBy).HasColumnName("PayBy");
            this.Property(t => t.Remark).HasColumnName("Remark");

        }
    }
}


