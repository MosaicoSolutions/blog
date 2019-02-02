using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Extensions
{
    public static class FindFluentExtensions
    {
        public static IOrderedFindFluent<TDocument, TProjection> Sort<TDocument, TProjection>(this IFindFluent<TDocument, TProjection> find,
                                                                                              Expression<Func<TDocument, object>> field,
                                                                                              SortDirection sortDirection)
            => sortDirection == SortDirection.Ascending
                    ? find.SortBy(field)
                    : find.SortByDescending(field);
    }
}
