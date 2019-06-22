using codefirstForWpf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstForWpf.DAL
{
    public class AccountContext :DbContext
    {
        public AccountContext()
                   : base("AccountContext")
        {

        }
        public DbSet<SysUser> SysUsers { get; set; }        //为每个表创建一个DbSet
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();          //指定单数形式的表名
            base.OnModelCreating(modelBuilder);             //指定一个连接字符串   显式的指定出构造函数中的 base("AccountContext")
        }

    }
}
 