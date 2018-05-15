using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2MemberBusinessTypeMap : EntityTypeConfiguration<MV2MemberBusinessType>
    {
        public MV2MemberBusinessTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BusinessTypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("MV2_MemberBusinessType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessTypeName).HasColumnName("BusinessTypeName");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.Remark).HasColumnName("Remark");

        }
    }
}


