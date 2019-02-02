using MongoDB.Bson.Serialization.Attributes;
using MosaicoSolutions.Blog.Domain.Core;
using System.Collections.Generic;

namespace MosaicoSolutions.Blog.Domain.Models
{
    public class Comment : Entity
    {
        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("site")]
        public string Site { get; set; }

        [BsonElement("text")]
        public string Text { get; set; }

        [BsonElement("children")]
        public ICollection<Comment> Children { get; set; }
    }
}
