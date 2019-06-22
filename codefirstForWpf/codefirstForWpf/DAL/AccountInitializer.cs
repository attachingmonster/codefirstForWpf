using codefirstForWpf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstForWpf.DAL
{
    public class AccountInitializer:
        DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<SysUser>        //添加数据库中SysUser表的内容
            {
                new SysUser {ID=1, UserName="Tom",Email="Tom@sohu.com",Password="1"},   
                new SysUser {ID=2, UserName ="Jerry",Email="Jerry@sohu.com",Password ="2"}
            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();
            var sysRole = new List<SysRole>         //添加数据库中SysRole表的内容
            {
                new SysRole {RoleName ="administrators",RoleDec ="administrtors have full authorization to perform systea administration."},
               new SysRole {RoleName ="general uners",RoleDec ="general users an access the shared data they are suthorized for."}
            };
            sysRole.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();
        }
    }
}
