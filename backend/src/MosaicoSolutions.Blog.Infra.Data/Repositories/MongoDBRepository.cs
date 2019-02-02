using MongoDB.Driver;
using MosaicoSolutions.Blog.Domain.Core;
using MosaicoSolutions.Blog.Domain.Core.Models;
using MosaicoSolutions.Blog.Domain.Repositories;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Contexts;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Extensions;
using System.Linq;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.Infra.Data.Repositories
{
    public class MongoDBRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly MongoDBContext mongoDBContext;

        public MongoDBRepository(MongoDBContext mongoDBContext) => this.mongoDBContext = mongoDBContext;

        public Task<IPage<TEntity>> Page(PagingParameter<TEntity> pagingParameter)
            => Task.Run<IPage<TEntity>>(async () =>
            {
                var collection = mongoDBContext.GetCollection<TEntity>();

                var recordsTotal = await collection.CountDocumentsAsync();

                var sort = Builders<TEntity>.Sort.By(pagingParameter.OrderBy, SortDirection.Ascending);

                var findFluent = collection.Find(pagingParameter.Filter)
                                           .Sort(sort);

                var filteredResults = await findFluent.CountDocumentsAsync();

                var skip = (pagingParameter.PageNumber - 1) * pagingParameter.PageSize;

                var pageData = await findFluent.Skip(skip)
                                               .Limit(pagingParameter.PageSize)
                                               .ToListAsync();

                return new Page<TEntity>
                {
                    Data = pageData,
                    RecordsTotal = recordsTotal,
                    RecordsFiltered = filteredResults
                };
            });
    }
}
