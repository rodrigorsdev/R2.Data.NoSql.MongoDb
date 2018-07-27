using MongoDB.Bson;

namespace R2.Data.NoSql.MongoDb.Model
{
    public abstract class ModelMongoDb
    {
        public ObjectId id { get; set; }
    }
}
