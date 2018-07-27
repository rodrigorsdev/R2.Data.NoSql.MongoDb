using Microsoft.Extensions.Options;
using MongoDB.Driver;
using R2.Data.NoSql.MongoDb.Interface;
using R2.Data.NoSql.MongoDb.Model;
using R2.Data.NoSql.MongoDb.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R2.Data.NoSql.MongoDb.Repository
{
    public class MongoDbBaseRepository<TEntity> : IMongoDbBaseRepository<TEntity>  where TEntity : class 
    {
        private readonly IMongoCollection<TEntity> _collection;

        public MongoDbBaseRepository(
            IOptions<MongoDbSettings> options,
            IMongoClient client)
        {
            var collection = typeof(TEntity).Name;
            _collection = client.GetDatabase(options.Value.Database).GetCollection<TEntity>(collection);
        }

        public Task Add(TEntity model)
        {
            return _collection.InsertOneAsync(model);
        }

        public Task Add(IEnumerable<TEntity> models)
        {
            return _collection.InsertManyAsync(models);
        }
    }
}
