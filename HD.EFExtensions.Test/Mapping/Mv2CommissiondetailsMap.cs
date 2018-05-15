using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2CommissionDetailsMap : EntityTypeConfiguration<MV2CommissionDetails>
    {
        public MV2CommissionDetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Login)
                .HasMaxLength(64);

            this.Property(t => t.ParentIds)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Commission)
                .HasMaxLength(1000);

            this.Property(t => t.Symbol)
                .HasMaxLength(16);

            this.Property(t => t.FollowerTargetNickName)
                .HasMaxLength(100);

            this.Property(t => t.TraderID)
                .HasMaxLength(100);

            this.Property(t => t.StandardSymbol)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("MV2_CommissionDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.BrokerId).HasColumnName("BrokerId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.ParentIds).HasColumnName("ParentIds");
            this.Property(t => t.TicketId).HasColumnName("TicketId");
            this.Property(t => t.Commission).HasColumnName("Commission");
            this.Property(t => t.FollowReturn).HasColumnName("FollowReturn");
            this.Property(t => t.OpenTime).HasColumnName("OpenTime");
            this.Property(t => t.CloseTime).HasColumnName("CloseTime");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Symbol).HasColumnName("Symbol");
            this.Property(t => t.FollowerTargetUserId).HasColumnName("FollowerTargetUserId");
            this.Property(t => t.FollowerTargetNickName).HasColumnName("FollowerTargetNickName");
            this.Property(t => t.TradeSymbolType).HasColumnName("TradeSymbolType");
            this.Property(t => t.OrderType).HasColumnName("OrderType");
            this.Property(t => t.BrokerCloseTime).HasColumnName("BrokerCloseTime");
            this.Property(t => t.TraderID).HasColumnName("TraderID");
            this.Property(t => t.TraderBrokderID).HasColumnName("TraderBrokderID");
            this.Property(t => t.FollowerCmd).HasColumnName("FollowerCmd");
            this.Property(t => t.StandardLots).HasColumnName("StandardLots");
            this.Property(t => t.StandardSymbol).HasColumnName("StandardSymbol");

        }
    }
}


