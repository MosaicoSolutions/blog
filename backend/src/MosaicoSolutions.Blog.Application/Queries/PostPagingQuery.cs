namespace MosaicoSolutions.Blog.Application.Queries
{
    public class PostPagingQuery : PagingQuery
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string[] Tags { get; set; }
    }
}
