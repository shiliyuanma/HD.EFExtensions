using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2CommissionRewardMap : EntityTypeConfiguration<MV2CommissionReward>
    {
        public MV2CommissionRewardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_CommissionReward");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.RewardMoney).HasColumnName("RewardMoney");
            this.Property(t => t.MonthCommission).HasColumnName("MonthCommission");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.RewardPercent).HasColumnName("RewardPercent");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.Remark).HasColumnName("Remark");

        }
    }
}


