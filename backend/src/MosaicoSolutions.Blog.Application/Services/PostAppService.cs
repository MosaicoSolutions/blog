using System.Linq;
using System.Threading.Tasks;
using MosaicoSolutions.Blog.Application.Services.Interfaces;
using MosaicoSolutions.Blog.Application.ViewModels;
using MosaicoSolutions.Blog.Application.ViewModels.Core;
using MosaicoSolutions.Blog.Domain.Core.Models;
using MosaicoSolutions.Blog.Domain.Models;
using MosaicoSolutions.Blog.Domain.Repositories;
using MosaicoSolutions.Blog.Domain.Core.Models.Extensions;
using Microsoft.AspNetCore.Hosting;

namespace MosaicoSolutions.Blog.Application.Services
{
    public class PostAppService : IPostAppService
    {
        private readonly IPostRepository postRepository;

        public PostAppService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public Task<IPage<PostPageViewModel>> Page(PagingViewModel<Post> pagingViewModel)
            => Task.Run(async () =>
            {
                var parameters = pagingViewModel.Parameters;

            var findOptions = new PagingParameter<Post>
            {
                PageNumber = pagingViewModel.Page.GetValueOrDefault(),
                PageSize = pagingViewModel.PageSize.GetValueOrDefault(),
                Filter = p => (parameters.Title != string.Empty || p.Title.Contains(parameters.Title) &&
                              (parameters.Category != string.Empty || p.Category.Contains(parameters.Category)) &&
                              (!parameters.Tags.Any() || p.Tags.Any(x => parameters.Tags.Contains(x)))),
                    Sort = pagingViewModel.Sort,
                    OrderBy = p => p.CreatedOn
                };

                var page = await postRepository.Page(findOptions);

                return page.Map(post => new PostPageViewModel
                {
                    Title = post.Title,
                    Category = post.Category,
                    Image = post.Image,
                    Tags = post.Tags
                });
            });
    }
}
