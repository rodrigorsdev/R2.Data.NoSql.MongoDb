using R2.Data.NoSql.MongoDb.Api.Domain.Model;
using System;
using System.Runtime.Serialization;

namespace R2.Data.NoSql.MongoDb.Api.Application.ViewModel
{
    public class UserRequest
    {
        public UserRequest()
        {
            if (Id == Guid.Empty)
                Id = Guid.NewGuid();
        }

        [IgnoreDataMember]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid AccessGroupId { get; set; }
        public string AccessGroupName { get; set; }

        public static implicit operator User(UserRequest vmodel)
        {
            if (vmodel == null)
                return null;

            return new User(
                vmodel.Id,
                vmodel.Name,
                vmodel.BirthDate,
                vmodel.AccessGroupId,
                vmodel.AccessGroupName);
        }
    }
}
