using System;

namespace MosaicoSolutions.Blog.Application.Queries
{
    public class PostPagingQuery : PagingQuery
    {
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string[] Tags { get; set; } = Array.Empty<string>();
    }
}
