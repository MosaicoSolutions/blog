using AutoMapper;
using MediatR;
using MosaicoSolutions.Blog.Application.MediatR.Request;
using MosaicoSolutions.Blog.Application.Queries;
using MosaicoSolutions.Blog.Application.Services.Interfaces;
using MosaicoSolutions.Blog.Application.ViewModels;
using MosaicoSolutions.Blog.Application.ViewModels.Core;
using MosaicoSolutions.Blog.Domain.Core.Models;
using MosaicoSolutions.Blog.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.Application.MediatR.RequestHandle
{
    public class PostPagingRequestHandle : IRequestHandler<PostPagingRequest, IPage<PostPageViewModel>>
    {
        private readonly IMapper mapper;
        private readonly IPostAppService postAppService;

        public PostPagingRequestHandle(IMapper mapper, IPostAppService postAppService)
        {
            this.mapper = mapper;
            this.postAppService = postAppService;
        }

        public Task<IPage<PostPageViewModel>> Handle(PostPagingRequest request, CancellationToken cancellationToken)
            => Task.Run(async () =>
            {
                var postPagingModel = mapper.Map<PostPagingQuery, PagingViewModel<Post>>(request.Query);

                var result = await postAppService.Page(postPagingModel);

                return result;
            });
}
}
