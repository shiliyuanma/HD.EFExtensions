using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2CommissionDailyMap : EntityTypeConfiguration<MV2CommissionDaily>
    {
        public MV2CommissionDailyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MT4Account)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Commission)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("MV2_CommissionDaily");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.BrokerId).HasColumnName("BrokerId");
            this.Property(t => t.MT4Account).HasColumnName("MT4Account");
            this.Property(t => t.Commission).HasColumnName("Commission");
            this.Property(t => t.FollowCommission).HasColumnName("FollowCommission");
            this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");

        }
    }
}


