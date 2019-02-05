using AutoMapper;
using MosaicoSolutions.Blog.Application.Queries;
using MosaicoSolutions.Blog.Application.ViewModels.Core;
using MosaicoSolutions.Blog.Domain.Models;

namespace MosaicoSolutions.Blog.Application.AutoMapper.Profiles
{
    public class PagingQueryProfile : Profile
    {
        public PagingQueryProfile()
        {
            CreateMap<PostPagingQuery, PagingViewModel<Post>>()
                .ForMember(x => x.Parameters, map => map.MapFrom(x => new Post
                {
                    Title = x.Title,
                    Tags = x.Tags,
                    Category = x.Category
                }));
        }
    }
}
