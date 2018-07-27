using System;

namespace R2.Data.NoSql.MongoDb.Api.Domain.Model
{
    public class User
    {
        public User(
            Guid id,
            string name,
            DateTime birthDate,
            Guid? accesGroupId,
            string accessGroupName)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;

            if (accesGroupId != null && accesGroupId.Value != Guid.Empty)
                SetAccesGroup(accesGroupId.Value, accessGroupName);
        }

        private void SetAccesGroup(
            Guid id,
            string name)
        {
            AccessGroup = new AccessGroup(id, name);
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public AccessGroup AccessGroup { get; private set; }
    }
}
