using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2ExcludeAccountMap : EntityTypeConfiguration<MV2ExcludeAccount>
    {
        public MV2ExcludeAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Login)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_ExcludeAccount");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.BrokerId).HasColumnName("BrokerId");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.AccountType).HasColumnName("AccountType");

        }
    }
}


