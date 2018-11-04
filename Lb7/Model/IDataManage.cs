using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7.Model
{
    interface IDataManage<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity FindById(int id);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        
        event EventHandler Load;

    }
}
