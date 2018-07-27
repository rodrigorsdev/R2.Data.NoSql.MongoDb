using System;

namespace R2.Data.NoSql.MongoDb.Api.Domain.Model
{
    public class AccessGroup
    {
        public AccessGroup(
            Guid id,
            string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
