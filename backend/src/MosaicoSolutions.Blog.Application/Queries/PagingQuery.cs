using MongoDB.Driver;

namespace MosaicoSolutions.Blog.Application.Queries
{
    public class PagingQuery
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public SortDirection Sort { get; set; } = SortDirection.Ascending;
    }
}
