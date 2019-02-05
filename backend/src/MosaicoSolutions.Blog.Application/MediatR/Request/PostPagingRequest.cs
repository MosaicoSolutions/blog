using MediatR;
using MosaicoSolutions.Blog.Application.Queries;
using MosaicoSolutions.Blog.Application.ViewModels;
using MosaicoSolutions.Blog.Domain.Core.Models;

namespace MosaicoSolutions.Blog.Application.MediatR.Request
{
    public class PostPagingRequest : IRequest<IPage<PostPageViewModel>>
    {
        public PostPagingQuery Query { get; set; }

        public PostPagingRequest(PostPagingQuery query) => Query = query;
    }
}
