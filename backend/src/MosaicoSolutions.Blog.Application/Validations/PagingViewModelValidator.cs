using FluentValidation;
using MosaicoSolutions.Blog.Application.ViewModels.Core;
using MosaicoSolutions.Blog.Domain.Core;

namespace MosaicoSolutions.Blog.Application.Validations
{
    public class PagingViewModelValidator<TEntity> : AbstractValidator<PagingViewModel<TEntity>> where TEntity : class, IEntity
    {
        public PagingViewModelValidator()
        {

        }
    }
}
