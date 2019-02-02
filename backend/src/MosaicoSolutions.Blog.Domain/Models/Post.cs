using MongoDB.Bson.Serialization.Attributes;
using MosaicoSolutions.Blog.Domain.Core;
using System.Collections.Generic;

namespace MosaicoSolutions.Blog.Domain.Models
{
    public class Post : Entity
    {
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("body")]
        public string Body { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }

        [BsonElement("category")]
        public string Category { get; set; }

        [BsonElement("tags")]
        public string[] Tags { get; set; }

        [BsonElement("comments")]
        public ICollection<Comment> Comments { get; set; }
    }
}
