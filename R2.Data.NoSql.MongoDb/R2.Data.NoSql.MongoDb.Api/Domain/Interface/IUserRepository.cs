using R2.Data.NoSql.MongoDb.Api.Domain.Model;
using R2.Data.NoSql.MongoDb.Interface;

namespace R2.Data.NoSql.MongoDb.Api.Domain.Interface
{
    public interface IUserRepository : IMongoDbBaseRepository<User>
    {
    }
}
