using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2MemberDailyMap : EntityTypeConfiguration<MV2MemberDaily>
    {
        public MV2MemberDailyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ParentIds)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_MemberDaily");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.BrokerId).HasColumnName("BrokerId");
            this.Property(t => t.NewUserCount).HasColumnName("NewUserCount");
            this.Property(t => t.ActiveUserCount).HasColumnName("ActiveUserCount");
            this.Property(t => t.Orders).HasColumnName("Orders");
            this.Property(t => t.Point).HasColumnName("Point");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Commission).HasColumnName("Commission");
            this.Property(t => t.Swaps).HasColumnName("Swaps");
            this.Property(t => t.Profit).HasColumnName("Profit");
            this.Property(t => t.Credit).HasColumnName("Credit");
            this.Property(t => t.WinOrders).HasColumnName("WinOrders");
            this.Property(t => t.LoseOrders).HasColumnName("LoseOrders");
            this.Property(t => t.WinProfit).HasColumnName("WinProfit");
            this.Property(t => t.LoseProfit).HasColumnName("LoseProfit");
            this.Property(t => t.WinPoint).HasColumnName("WinPoint");
            this.Property(t => t.LosePoint).HasColumnName("LosePoint");
            this.Property(t => t.MaxPoint).HasColumnName("MaxPoint");
            this.Property(t => t.MinPoint).HasColumnName("MinPoint");
            this.Property(t => t.BuyOrders).HasColumnName("BuyOrders");
            this.Property(t => t.SellOrders).HasColumnName("SellOrders");
            this.Property(t => t.WinAndBuyOrders).HasColumnName("WinAndBuyOrders");
            this.Property(t => t.WinAndSellOrders).HasColumnName("WinAndSellOrders");
            this.Property(t => t.InMoney).HasColumnName("InMoney");
            this.Property(t => t.FollowVolume).HasColumnName("FollowVolume");
            this.Property(t => t.SlefVolume).HasColumnName("SlefVolume");
            this.Property(t => t.BuyVolume).HasColumnName("BuyVolume");
            this.Property(t => t.SellVolume).HasColumnName("SellVolume");
            this.Property(t => t.Balance).HasColumnName("Balance");
            this.Property(t => t.BalancePrev).HasColumnName("BalancePrev");
            this.Property(t => t.Equity).HasColumnName("Equity");
            this.Property(t => t.FollowProfit).HasColumnName("FollowProfit");
            this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
            this.Property(t => t.ParentIds).HasColumnName("ParentIds");
            this.Property(t => t.OutMoney).HasColumnName("OutMoney");

        }
    }
}


