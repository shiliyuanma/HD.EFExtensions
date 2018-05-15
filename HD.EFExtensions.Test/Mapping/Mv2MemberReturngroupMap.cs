using FM.Member.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2MemberReturnGroupMap : EntityTypeConfiguration<MV2MemberReturnGroup>
    {
        public MV2MemberReturnGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MemberId, t.ReturnGroupId, t.MemberBusinessTypeId, t.Status });

            // Properties
            this.Property(t => t.MemberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MemberBusinessTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MV2_Member_ReturnGroup");
            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.ReturnGroupId).HasColumnName("ReturnGroupId");
            this.Property(t => t.MemberBusinessTypeId).HasColumnName("MemberBusinessTypeId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.Remark).HasColumnName("Remark");

        }
    }
}


