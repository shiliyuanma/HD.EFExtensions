using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2MemberCommissionSummaryMap : EntityTypeConfiguration<MV2MemberCommissionSummary>
    {
        public MV2MemberCommissionSummaryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("MV2_MemberCommissionSummary");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.MemberAmount).HasColumnName("MemberAmount");
            this.Property(t => t.PaidAmount).HasColumnName("PaidAmount");
            this.Property(t => t.Applied).HasColumnName("Applied");
            this.Property(t => t.Balance).HasColumnName("Balance");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");

        }
    }
}


