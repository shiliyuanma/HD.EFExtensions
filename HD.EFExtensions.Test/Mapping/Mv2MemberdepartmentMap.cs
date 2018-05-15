using FM.Member.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FM.Member.DAO.Mapping
{
    public class MV2MemberDepartmentMap : EntityTypeConfiguration<MV2MemberDepartment>
    {
        public MV2MemberDepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.SubDomain)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MV2_MemberDepartment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.SysUserId).HasColumnName("SysUserId");
            this.Property(t => t.MemberType).HasColumnName("MemberType");
            this.Property(t => t.MemberState).HasColumnName("MemberState");
            this.Property(t => t.SubDomain).HasColumnName("SubDomain");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
            this.Property(t => t.ApplyDate).HasColumnName("ApplyDate");
            this.Property(t => t.EnableDate).HasColumnName("EnableDate");
            this.Property(t => t.UnPassReasons).HasColumnName("UnPassReasons");

        }
    }
}


