using MongoDB.Driver;
using System;
using System.Linq.Expressions;

namespace MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Extensions
{
    public static class SortDefinitionBuilderExtensions
    {
        public static SortDefinition<TDocument> By<TDocument>(this SortDefinitionBuilder<TDocument> sortDefinitionBuilder,
                                                              Expression<Func<TDocument, object>> field,
                                                              SortDirection sortDirection)
            => sortDirection == SortDirection.Ascending
                    ? sortDefinitionBuilder.Ascending(field)
                    : sortDefinitionBuilder.Descending(field);
    }
}
