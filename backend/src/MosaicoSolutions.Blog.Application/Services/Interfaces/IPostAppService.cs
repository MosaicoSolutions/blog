using MosaicoSolutions.Blog.Application.ViewModels;
using MosaicoSolutions.Blog.Application.ViewModels.Core;
using MosaicoSolutions.Blog.Domain.Core.Models;
using MosaicoSolutions.Blog.Domain.Models;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.Application.Services.Interfaces
{
    
    public interface IPostAppService
    {
        Task<IPage<PostPageViewModel>> Page(PagingViewModel<Post> pagingViewModel);
    }
}
