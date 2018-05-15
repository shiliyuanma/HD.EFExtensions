using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2MemberRelationShipMap : EntityTypeConfiguration<MV2MemberRelationShip>
    {
        public MV2MemberRelationShipMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ParentIds)
                .HasMaxLength(500);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            this.Property(t => t.ParentLevelCode)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("MV2_MemberRelationShip");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.ParentIds).HasColumnName("ParentIds");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.ParentLevelCode).HasColumnName("ParentLevelCode");

        }
    }
}


