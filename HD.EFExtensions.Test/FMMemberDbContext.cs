using FM.Member.DAO.Mapping;
using FM.Member.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;

namespace FM.Member.DAO
{
    public class FMMemberDbContext : DbContext
    {
        static bool initEF = false;

        static FMMemberDbContext()
        {
            Database.SetInitializer<FMMemberDbContext>(null);
        }

        public FMMemberDbContext() : base("Name=member")
        {
            Configuration.LazyLoadingEnabled = false;

            //EF预热
            if(!initEF)
            {
                var objectContext = ((IObjectContextAdapter)this).ObjectContext;
                var mappingCollection = (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
                mappingCollection.GenerateViews(new List<EdmSchemaError>());

                initEF = true;
            }
        }

        public DbSet<MV2ApplyCommissionInfo> MV2ApplyCommissionInfo { get; set; }
        public DbSet<MV2CommissionDaily> MV2CommissionDaily { get; set; }
        public DbSet<MV2CommissionDetails> MV2CommissionDetails { get; set; }
        public DbSet<MV2CommissionReward> MV2CommissionReward { get; set; }
        public DbSet<MV2ExcludeAccount> MV2ExcludeAccount { get; set; }
        public DbSet<MV2MemberBusinessType> MV2MemberBusinessType { get; set; }
        public DbSet<MV2MemberCommissionSummary> MV2MemberCommissionSummary { get; set; }
        public DbSet<MV2MemberDaily> MV2MemberDaily { get; set; }
        public DbSet<MV2MemberDepartment> MV2MemberDepartment { get; set; }
        public DbSet<MV2MemberInfo> MV2MemberInfo { get; set; }
        public DbSet<MV2MemberRelationShip> MV2MemberRelationShip { get; set; }
        public DbSet<MV2MemberReturnGroup> MV2MemberReturnGroup { get; set; }
        public DbSet<MV2ReturnConfig> MV2ReturnConfig { get; set; }
        public DbSet<MV2ReturnGroup> MV2ReturnGroup { get; set; }
        public DbSet<MV2ReturnGroupReturnConfig> MV2ReturnGroupReturnConfig { get; set; }
        public DbSet<MV2SpecialSymbol> MV2SpecialSymbol { get; set; }
        public DbSet<MV2UserDeviceToken> MV2UserDeviceToken { get; set; }
        public DbSet<MV2UserMember> MV2UserMember { get; set; }
        public DbSet<MTradeTypeConfig> MTradeTypeConfig { get; set; }
        public DbSet<UUser> UUser { get; set; }
        public DbSet<TUserAccount> TUserAccount { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MV2ApplyCommissionInfoMap());
            modelBuilder.Configurations.Add(new MV2CommissionDailyMap());
            modelBuilder.Configurations.Add(new MV2CommissionDetailsMap());
            modelBuilder.Configurations.Add(new MV2CommissionRewardMap());
            modelBuilder.Configurations.Add(new MV2ExcludeAccountMap());
            modelBuilder.Configurations.Add(new MV2MemberBusinessTypeMap());
            modelBuilder.Configurations.Add(new MV2MemberCommissionSummaryMap());
            modelBuilder.Configurations.Add(new MV2MemberDailyMap());
            modelBuilder.Configurations.Add(new MV2MemberDepartmentMap());
            modelBuilder.Configurations.Add(new MV2MemberInfoMap());
            modelBuilder.Configurations.Add(new MV2MemberRelationShipMap());
            modelBuilder.Configurations.Add(new MV2MemberReturnGroupMap());
            modelBuilder.Configurations.Add(new MV2ReturnConfigMap());
            modelBuilder.Configurations.Add(new MV2ReturnGroupMap());
            modelBuilder.Configurations.Add(new MV2ReturnGroupReturnConfigMap());
            modelBuilder.Configurations.Add(new MV2SpecialSymbolMap());
            modelBuilder.Configurations.Add(new MV2UserDeviceTokenMap());
            modelBuilder.Configurations.Add(new MV2UserMemberMap());
            modelBuilder.Configurations.Add(new MTradeTypeConfigMap());
            modelBuilder.Configurations.Add(new UUserMap());
            modelBuilder.Configurations.Add(new TUserAccountMap());

        }
    }
}
