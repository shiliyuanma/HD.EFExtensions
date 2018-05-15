using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2ReturnGroupMap : EntityTypeConfiguration<MV2ReturnGroup>
    {
        public MV2ReturnGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ReturnGroupId);

            // Properties
            this.Property(t => t.ReturnGroupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_ReturnGroup");
            this.Property(t => t.ReturnGroupId).HasColumnName("ReturnGroupId");
            this.Property(t => t.ReturnGroupName).HasColumnName("ReturnGroupName");
            this.Property(t => t.MemberBusinessTypeId).HasColumnName("MemberBusinessTypeId");
            this.Property(t => t.OrderByNumber).HasColumnName("OrderByNumber");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.Remark).HasColumnName("Remark");

        }
    }
}


