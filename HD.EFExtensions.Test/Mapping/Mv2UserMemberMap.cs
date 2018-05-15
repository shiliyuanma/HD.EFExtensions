using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2UserMemberMap : EntityTypeConfiguration<MV2UserMember>
    {
        public MV2UserMemberMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ParentIds)
                .HasMaxLength(300);

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
            this.ToTable("MV2_User_Member");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.ParentIds).HasColumnName("ParentIds");
            this.Property(t => t.MemberBusinessTypeId).HasColumnName("MemberBusinessTypeId");
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


