using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MosaicoSolutions.Blog.Domain.Core
{
    public class Entity : IEntity
    {
        private DateTime _createdOn;

        public Entity() => Id = ObjectId.GenerateNewId().ToString();

        [BsonElement(Order = 0)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("created_on", Order = 1)]
        public DateTime CreatedOn
        {
            get
            {
                if (_createdOn == null || _createdOn == DateTime.MinValue)
                    _createdOn = ObjectId.CreationTime;
                return _createdOn;
            }
            set
            {
                _createdOn = value;
            }
        }

        [BsonElement("modified_on", Order = 2)]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? ModifiedOn { get; set; }

        public ObjectId ObjectId => ObjectId.Parse(Id);
    }
}
