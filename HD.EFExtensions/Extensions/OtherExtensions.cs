using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace HD.EFExtensions
{
    /// <summary>
    /// 輔助類
    /// </summary>
    public static class EntityFrameworkHelper
    {     
        /// <summary>
        /// 当EF自动代理类关闭时，在结果集中包含直接被查询对象的指定导航属性的数据
        /// </summary>
        /// <typeparam name="T">被查询对象的类型</typeparam>
        /// <param name="dbSet">EF对象集</param>
        /// <param name="exp">指定导航属性的属性表达式，可以包含First、FirstOrDefault等Lambda方法</param>
        /// <returns>返回包含指定导航属性数据的查询集</returns>
        public static IQueryable<T> IncludeNice<T>(this IDbSet<T> dbSet, Expression<Func<T,dynamic>> exp)
            where T : class
        {
            return dbSet.Include(GetStrForInclude(exp));
        }

        /// <summary>
        /// 当EF自动代理类关闭时，在结果集中包含直接被查询对象的指定导航属性的数据
        /// </summary>
        /// <typeparam name="T">被查询对象的类型</typeparam>
        /// <param name="query">原始查询集</param>
        /// <param name="exp">指定导航属性的属性表达式，可以包含First、FirstOrDefault等Lambda方法</param>
        /// <returns>返回包含指定导航属性数据的查询集</returns>
        public static IQueryable<T> IncludeNice<T>(this IQueryable<T> query, Expression<Func<T,dynamic>> exp)
            where T : class
        {
            return query.Include(GetStrForInclude(exp));
        }

        private static string GetStrForInclude<T>(Expression<Func<T,dynamic>> exp)
            where T : class
        {
            string str = string.Empty;
            Expression expression = exp.Body;
            if (!(expression is MemberExpression))
            {
                throw new ArgumentException("Must be 'MemberExpression'.");
            }
            while (expression is MemberExpression || expression is MethodCallExpression)
            {
                var memberExp = expression as MemberExpression;
                if (memberExp != null)
                {
                    str = string.Concat(memberExp.Member.Name, ".", str);
                    expression = memberExp.Expression;
                }
                else
                {
                    var callExp = expression as MethodCallExpression;
                    if (callExp == null || callExp.Arguments == null || callExp.Arguments.Count == 0)
                    {
                        throw new ArgumentException("Not a right format expression.");
                    }
                    expression = callExp.Arguments[0];
                }
            }
            //if (!string.IsNullOrEmpty(str)) 
            //    str = str.Substring(str.Split('.')[0].Length).TrimStart('.').TrimEnd('.');
            return str.TrimEnd('.');
        }

        /// <summary>
        /// 集合翻页
        /// </summary>
        /// <typeparam name="T">source 中的元素的类型</typeparam>
        /// <param name="source">要翻页的IEnumerable</param>
        /// <param name="totalCount">輸出總記錄數</param>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页面大小</param>
        /// <returns>指定页子集合</returns>
        internal static IQueryable<T> Paging<T>(this IQueryable<T> source, out int totalCount, int pageIndex = 1, int pageSize = 20)
        {
            totalCount = source.Count();
            if (pageIndex <= 0) pageIndex = 1;
            if (pageSize <= 0) pageSize = 20;
            return source.Skip(((pageIndex - 1) * pageSize) < totalCount ? ((pageIndex - 1) * pageSize) : totalCount - (totalCount % pageSize)).Take(pageSize);
        }
    }
}