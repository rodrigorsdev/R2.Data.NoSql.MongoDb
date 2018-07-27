using System.Collections.Generic;
using R2.Data.NoSql.MongoDb.Model;
using System.Threading.Tasks;

namespace R2.Data.NoSql.MongoDb.Interface
{
    public interface IMongoDbBaseRepository<TEntity> where TEntity : class 
    {
        Task Add(TEntity model);
        Task Add(IEnumerable<TEntity> models);
    }
}
