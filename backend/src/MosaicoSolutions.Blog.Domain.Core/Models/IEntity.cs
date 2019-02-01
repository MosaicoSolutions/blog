using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MosaicoSolutions.Blog.Domain.Core
{
    public interface IEntity
    {
        [BsonId]
        string Id { get; set; }

        [BsonIgnore]
        ObjectId ObjectId { get; }

        DateTime CreatedOn { get; }

        DateTime? ModifiedOn { get; }
    }
}
