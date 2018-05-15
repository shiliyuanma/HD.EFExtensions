using FM.Member.DAO;
using FM.Member.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HD.EFExtensions.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FMMemberDbContext())
            {
                BatchLog.UpdateLog = (sql, para) =>
                {

                };
                BatchLog.DeleteLog = (sql, para) =>
                {

                };

                //批量添加
                db.BulkInsert(new List<MV2ReturnGroup>
                {
                    new MV2ReturnGroup
                    {
                        ReturnGroupId = Guid.NewGuid(),
                        ReturnGroupName = "test_1",
                        MemberBusinessTypeId = 1,
                        CreatedDate = DateTime.Now,
                        CreatedBy = "system",
                        UpdatedDate = DateTime.Now,
                        UpdatedBy = "system"
                    },
                    new MV2ReturnGroup
                    {
                        ReturnGroupId = Guid.NewGuid(),
                        ReturnGroupName = "test_2",
                        MemberBusinessTypeId = 1,
                        CreatedDate = DateTime.Now,
                        CreatedBy = "system",
                        UpdatedDate = DateTime.Now,
                        UpdatedBy = "system"
                    }
                });

                //批量更新
                db.MV2ReturnGroup.Where(q => q.UpdatedBy == "system").Update(m => new MV2ReturnGroup
                {
                    ReturnGroupName = m.ReturnGroupName + " 123"
                });

                //批量删除
                db.MV2ReturnGroup.Where(q => q.UpdatedBy == "system").Delete();

            }
        }
    }
}
