using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2UserDeviceTokenMap : EntityTypeConfiguration<MV2UserDeviceToken>
    {
        public MV2UserDeviceTokenMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DeviceToken)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_User_DeviceToken");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.DeviceToken).HasColumnName("DeviceToken");
            this.Property(t => t.PlatformType).HasColumnName("PlatformType");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");

        }
    }
}


