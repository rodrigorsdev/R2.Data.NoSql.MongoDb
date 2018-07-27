using Microsoft.Extensions.Options;
using MongoDB.Driver;
using R2.Data.NoSql.MongoDb.Api.Domain.Interface;
using R2.Data.NoSql.MongoDb.Api.Domain.Model;
using R2.Data.NoSql.MongoDb.Repository;
using R2.Data.NoSql.MongoDb.Settings;

namespace R2.Data.NoSql.MongoDb.Api.Infra.Repository
{
    public class UserRepository : MongoDbBaseRepository<User>, IUserRepository
    {
        public UserRepository(
            IOptions<MongoDbSettings> options,
            IMongoClient client) : base(options, client)
        {
        }
    }
}
