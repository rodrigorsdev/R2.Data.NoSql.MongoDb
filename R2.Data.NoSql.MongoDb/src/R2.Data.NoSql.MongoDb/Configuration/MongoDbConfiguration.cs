using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using R2.Data.NoSql.MongoDb.Settings;

namespace R2.Data.NoSql.MongoDb.Configuration
{
    public static class MongoDbConfiguration
    {
        public static void AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDbSettings>(options =>
            {
                options.ServerUrl = configuration.GetSection("MongoDb:ServerUrl").Value;
                options.Database = configuration.GetSection("MongoDb:Database").Value;
            });

            services.AddSingleton<IMongoClient, MongoClient>();
        }
    }
}
