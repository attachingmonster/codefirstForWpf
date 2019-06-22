using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace codefirstForWpf.Repositories
{
    interface IGenericRepository<TEntity> where TEntity : class  //:IDisIQposable
    {
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordeyBy = null,
            string includeProperties = "");
        TEntity GetByID(object id);         //查询
        void Insert(TEntity entity);        //增加
        void Delete(object id);             //删除
        void Update(TEntity entity);        //上传
        void Save();                        //保存 

    }
}
